using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();
    private float weight = 0.0f;
    private float maxWeight = 100.0f;

    public bool AddItem(Item item)
    {
        if (weight + item.GetWeight() <= maxWeight)
        {
            items.Add(item);
            weight += item.GetWeight();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool RemoveItem(Item item)
    {
        bool removed = items.Remove(item);

        if (removed)
        {
            weight -= item.GetWeight();
        }

        return removed;
    }

    public bool HasItem(Item item)
    {
        return items.Contains(item);
    }

    public bool CanOpenDoor(int id)
    {
        bool result = false;

        foreach (Item item in items)
        {
            if (item is AccessItem)
            {
                if (((AccessItem) item).OpensDoor(id))
                {
                    result = true;
                }
            }
        }

        return result;
    }

    public int Count()
    {
        return items.Count;
    }

    public float GetCurrentWeight()
    {
        return weight;
    }
}
