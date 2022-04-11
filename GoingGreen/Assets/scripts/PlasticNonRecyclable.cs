using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticNonRecyclable : MonoBehaviour
{
    private List<string> trash = new List<string>();

    void Start()
    {
        trash.Add("Polystyrene containers");
        trash.Add("Straws");
        trash.Add("Disposable cutlery");
        trash.Add("Old cassettes");
        trash.Add("Bag of chips");
        trash.Add("Food-stained plastic");
        trash.Add("PVC");
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
