using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public Inventory inventory;

    public Rigidbody rb;

    public int doorID;

    private void Start()
    {
        gameObject.tag = "Interactable";

        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void Action(PlayerManager player)
    {
        if (player.CanOpenDoor(doorID))
        {
            rb.constraints = RigidbodyConstraints.None;
            Debug.Log("Test");
        }
    }
}
