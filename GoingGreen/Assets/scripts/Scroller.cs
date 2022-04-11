using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    /// <summary>
    /// script to enable player and camera to move forward
    /// </summary>

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0f * Time.deltaTime, 0f * Time.deltaTime, speed * Time.deltaTime, Space.World);
    }
}
