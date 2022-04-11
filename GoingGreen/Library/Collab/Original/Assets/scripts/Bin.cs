using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    /// <summary>
    /// bin script for scoring points when players toss trash in
    /// </summary>

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Recyclable")
        {
            Debug.Log("Collision detected");
            GameController.instance.GameScore();
            col.gameObject.SetActive(false);
        }
    }
}
