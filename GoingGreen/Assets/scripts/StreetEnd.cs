using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetEnd : MonoBehaviour
{
    /// <summary>
    /// returns the end of level screen when the collider is triggered
    /// </summary>
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "MainCamera")
        {
            Debug.Log("End reached");
            GameController.instance.LevelEnd();
        }
    }
}
