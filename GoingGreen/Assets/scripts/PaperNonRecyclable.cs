using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperNonRecyclable : MonoBehaviour, IInteractable
{
    private List<string> trash = new List<string>();

    void Start()
    {
        trash.Add("Soiled newspaper");
        trash.Add("Soiled cardboard");
        trash.Add("Shredded paper");
        trash.Add("Paper cups");
        trash.Add("Plastic-coated paper");
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
