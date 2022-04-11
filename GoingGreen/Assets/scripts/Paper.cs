using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour, IInteractable
{
    private List<string> recyclables = new List<string>();

    void Start()
    {
        recyclables.Add("Newspaper");
        recyclables.Add("Writing paper");
        recyclables.Add("Scrap paper");
        recyclables.Add("Magazine");
        recyclables.Add("Notebook");
        recyclables.Add("Phone book");
        recyclables.Add("Catalogs");
        recyclables.Add("Paper packaging");
        recyclables.Add("Envelope");
        recyclables.Add("Paper bag");
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
