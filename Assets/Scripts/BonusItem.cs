using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItem : Item
{
    int points;

    public BonusItem(string name, float weight, int points) : base(name, weight)
    {
        this.points = points;
    }

    public int GetPoints()
    {
        return points;
    }
}
