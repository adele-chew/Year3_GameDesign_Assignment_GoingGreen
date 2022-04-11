using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    /// <summary>
    /// bin script for scoring points when players toss trash in
    /// </summary>

   AudioSource Audiosource;



    void Start()
    {
        Audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Recyclable")
        {
            GameController.instance.GameScore();
            Audiosource.Play();
            col.gameObject.SetActive(false);
            Debug.Log("Score!");
        }
    }
}
