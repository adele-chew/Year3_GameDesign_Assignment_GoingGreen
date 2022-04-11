using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plastic : MonoBehaviour
{
    private List<string> recyclables = new List<string>();

    void Start()
    {
        recyclables.Add("Water bottles");
        recyclables.Add("Detergent bottle");
        recyclables.Add("CD Casing");
        recyclables.Add("Plastic bags");
        recyclables.Add("Bubble wrap");
        recyclables.Add("Clothes hangers");
        recyclables.Add("Plastic packaging");
    }

    string RandomRecyclable()
    {
        int index = Random.Range(0, recyclables.Count);

        return (recyclables[index]);
    }

    public string GetDescription()
    {
        return RandomRecyclable();
    }
}
