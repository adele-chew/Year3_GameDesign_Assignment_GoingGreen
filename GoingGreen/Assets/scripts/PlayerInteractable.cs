using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractable : MonoBehaviour
{
    /// <summary>
    /// displays the name of the material on the UI display 
    /// </summary>
 
    public Camera mainCam;
    public float radius = 2f;

    public GameObject itemName;
    public TextMeshProUGUI itemNameText;

    public bool viewItem;
    public int flag = 0;
    public Transform detectItem;

    public float DropPosX;
    public float DropPosY;
    public float DropPosZ;

    private IInteractable interactable;

    void Start()
    {
        itemName.SetActive(false);
    }

    void Update()
    {
        RayInteraction();
    }

    void RayInteraction()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;
        viewItem = false;
        if (Physics.Raycast(ray, out hit, radius))
        {
            interactable = hit.collider.gameObject.GetComponent<IInteractable>();
            DropPosX = hit.point.x;
            DropPosY = hit.point.y;
            DropPosZ = hit.point.z;
            detectItem = hit.collider.transform;

            if (interactable != null)
            {
                viewItem = true;
                UIActive();
            }
            else
            {
                viewItem = false;
                itemName.SetActive(false);
                itemNameText.text = null;
            }
        }
    }

    void UIActive()
    {
        if(viewItem && !itemName.activeSelf)
        {
            itemName.SetActive(true);
            itemNameText.text = interactable.GetDescription();
        }       
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Trash")
        {
            GameController.instance.GameDeduct();
            col.gameObject.SetActive(false);
            Debug.Log("Subtracting score");
        }
    }
}
