using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Access : PickUp
{
    public int doorID;

    public override Item CreateItem()
    {
        return new AccessItem(itemName, weight, doorID);
    }
}
