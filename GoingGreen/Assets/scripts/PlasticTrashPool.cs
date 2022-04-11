using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticTrashPool : MonoBehaviour
{
    /// <summary>
    /// spawns a set number of trash in an array and 
    /// spawns the items in random locations
    /// and repositions the items once the array is cycled through
    /// </summary>

    public int trashPoolSize = 6;
    public GameObject trashPrefab;
    public float spawnRate = 5f;
    public float trashXMin = -50f;
    public float trashXMax = 0f;
    public float spawnDist = 100f;

    private GameObject[] trash;
    private Vector3 objectPoolPos = new Vector3(0f, 200f, 0f);
    private float timeSinceLastSpawned;
    private float spawnYPos = 560f;
    private float spawnZpos;
    private int currentTrash = 0;

    // Start is called before the first frame update
    void Start()
    {
        trash = new GameObject[trashPoolSize];
        for (int i = 0; i < trashPoolSize; i++)
        {
            trash[i] = (GameObject)Instantiate(trashPrefab, objectPoolPos, Quaternion.Euler(-90, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.levelEnd == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            spawnZpos = Camera.main.transform.position.z + spawnDist + 500f;
            float spawnXpos = Random.Range(trashXMin, trashXMax);
            trash[currentTrash].SetActive(true);
            trash[currentTrash].transform.position = new Vector3(spawnXpos, spawnYPos, spawnZpos);
            trash[currentTrash].GetComponent<Rigidbody>().isKinematic = true;
            currentTrash++;

            if (currentTrash >= trashPoolSize)
            {
                currentTrash = 0;
            }
        }
    }
}
