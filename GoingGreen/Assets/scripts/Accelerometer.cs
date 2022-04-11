using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    /// <summary>
    /// class to use the accelerometer for movement on WebXR
    /// </summary>
    private float speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsAccelerometer)
        {
            Debug.Log("Accelerometer detected");
        }else
        {
            Debug.Log("No accelerometer found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        dir.y = 0;
        dir.z = 0;

        if(dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;

        transform.Translate(dir * speed);
    }
}
