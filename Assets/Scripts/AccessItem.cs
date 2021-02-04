using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessItem : Item
{
    private int doorID;

    public AccessItem(string name, float weight, int doorID) : base(name, weight)
    {
        this.doorID = doorID;
    }

    public int GetDoorID()
    {
        return doorID;
    }

    public bool OpensDoor(int id)
    {
        return doorID == id;
    }
}
