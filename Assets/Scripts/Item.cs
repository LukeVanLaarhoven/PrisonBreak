using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    // properties
    private string name;
    private float weight;

    // constructors
    public Item(string name, float weight)
    {
        this.name = name;
        this.weight = weight;
    }

    // methods
    public string GetName()
    {
        return name;
    }

    public float GetWeight()
    {
        return weight;
    }
}
