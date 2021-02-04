using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public Inventory inventory;

    private void Start()
    {
        CreateAccessItem();
        TestInventory();
    }

    private void TestInventory()
    {
        Debug.Log("============================Inventory==============================");
        Item key_1 = new AccessItem("key_1", 5.0f, 1);
        Item bonusItem_1 = new BonusItem("BonusItem_1", 2.0f, 100);
        Item puzzleItem_1 = new PuzzleItem("PuzzleItem_1", 1.0f, "What is 5 + 5 ", "10");

        inventory.AddItem(key_1);
        inventory.AddItem(bonusItem_1);
        inventory.AddItem(puzzleItem_1);

        DebugInventory();

        if (inventory.CanUseItem(1, ""))
        {
            Debug.Log("Door 1 can be opened");
        }
        else
        {
            Debug.Log("Door 1 cannot be opened");
        }

        if (inventory.CanUseItem(2, ""))
        {
            Debug.Log("Door 2 can be opened");
        }
        else
        {
            Debug.Log("Door 2 cannot be opened");
        }

        if (((PuzzleItem)puzzleItem_1).PuzzleResult("10"))
        {
            Debug.Log("Puzzle is correct");
        }
        else
        {
            Debug.Log("Puzzle is incorrect");
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

        Item puzzleItem_1 = new PuzzleItem("PuzzleItem", 1.0f, "What is 5 + 5 ", "10");
        DebugItem(puzzleItem_1);
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
            BonusItem BonusItem_1a = (BonusItem)item;
            extraInfo = " " + BonusItem_1a.GetPoints();
        }
        else if (item is PuzzleItem)
        {
            PuzzleItem puzzleItem_1a = (PuzzleItem)item;
            extraInfo = " " + puzzleItem_1a.GetpuzzleRiddle();
        }

        Debug.Log(itemInfo + extraInfo);
    }
}
