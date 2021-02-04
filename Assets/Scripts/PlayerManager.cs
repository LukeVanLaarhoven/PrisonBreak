using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Inventory inventory;
    public float initialMaxWeight = 100.0f;

    private void Start()
    {
        inventory = new Inventory(initialMaxWeight);
    }

    public bool AddItem(Item item)
    {
        return inventory.AddItem(item);
    }

    public bool CanOpenDoor(int id)
    {
        return inventory.CanOpenDoor(id);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Interactable"))
        {
            IInteractable item = col.gameObject.GetComponent<IInteractable>();
            item.Action(this);
        }
    }
}
