using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour
{
    private List<string> recyclables = new List<string>();

    void Start()
    {
        recyclables.Add("Canned drink");
        recyclables.Add("Food cans");
        recyclables.Add("Metal bottle caps");
        recyclables.Add("Aerosol cans");
        recyclables.Add("Clean aluminium foil");
        recyclables.Add("Paint container");
        recyclables.Add("Copper wires");
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
