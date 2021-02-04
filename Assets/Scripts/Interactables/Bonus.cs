using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : PickUp
{
    public int points;

    public override Item CreateItem()
    {
        return new BonusItem(itemName, weight, points);
    }
}
