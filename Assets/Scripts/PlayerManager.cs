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

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2.0f) && Input.GetKeyDown(KeyCode.E))
        {
            if (hit.collider.gameObject.CompareTag("Interactable"))
            {
                IInteractable item = hit.collider.gameObject.GetComponent<IInteractable>();
                item.Action(this);
            }
        }
    }

    public bool AddItem(Item item)
    {
        return inventory.AddItem(item);
    }

    public bool CanOpenDoor(int id)
    {
        return inventory.CanOpenDoor(id);
    }
}
