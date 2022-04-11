using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;
    public float throwForce = 600f;
    public AudioSource Audiosource;

    private Vector3 objectPos;
    private float distance;

    void Start()
    {
        Audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if isHolding
        if (isHolding == true)
        {
            /*distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
            if(distance >= 1f)
            {
                isHolding = false;
            }*/

            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);
            
            if (Input.GetMouseButtonDown(0))
            {
                //throw
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Audiosource.Play();

        if(col.GetComponent<Scroller>() != null)
        {
            //if (distance <= 1f){ }
            isHolding = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
        else if (isHolding == true)
        {
            return;
        }
    }
}
