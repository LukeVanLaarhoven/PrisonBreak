using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public Inventory inventory;

    private void Start()
    {
        inventory = new Inventory(150.0f);

        CreateAccessItem();
        TestInventory();
    }

    private void TestInventory()
    {
        Debug.Log("============================Inventory==============================");
        Item key_1 = new AccessItem("key_1", 5.0f, 1);
        Item bonusItem_1 = new BonusItem("BonusItem_1", 2.0f, 100);

        inventory.AddItem(key_1);
        inventory.AddItem(bonusItem_1);

        DebugInventory();

        if (inventory.CanOpenDoor(1))
        {
            Debug.Log("Door 1 can be opened");
        }
        else
        {
            Debug.Log("Door 1 cannot be opened");
        }

        if (inventory.CanOpenDoor(2))
        {
            Debug.Log("Door 2 can be opened");
        }
        else
        {
            Debug.Log("Door 2 cannot be opened");
        }
    }

    private void DebugInventory()
    {
        Debug.Log(inventory.Count());
        Debug.Log(inventory.GetCurrentWeight());
    }

    public void CreateAccessItem()
    {
        Debug.Log("============================ItemCreation==============================");

        Item key_1 = new AccessItem("Key_1", 5.0f, 1);
        DebugItem(key_1);

        Item bonusItem = new BonusItem("BonusItem", 10.0f, 100);
        DebugItem(bonusItem);
    }

    public void DebugItem(Item item)
    {
        string itemInfo = item.GetName() + " " + item.GetWeight();
        string extraInfo = "";

        if (item is AccessItem)
        {
            AccessItem key_1a = (AccessItem)item;
            extraInfo = " " + key_1a.GetDoorID();
        }
        else if (item is BonusItem)
        {
            BonusItem BonusItem_a = (BonusItem)item;
            extraInfo = " " + BonusItem_a.GetPoints();
        }

        Debug.Log(itemInfo + extraInfo);
    }
}
