using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalNonRecylable : MonoBehaviour
{
    private List<string> trash = new List<string>();

    void Start()
    {
        trash.Add("Gas tanks");
        trash.Add("Batteries");
        trash.Add("CDs");
        trash.Add("Pots and pans");
        trash.Add("Radioactive metals");
        trash.Add("Lead");
        trash.Add("Mercury");
    }

    string RandomRecyclable()
    {
        int index = Random.Range(0, trash.Count);

        return (trash[index]);
    }

    public string GetDescription()
    {
        return RandomRecyclable();
    }
}
