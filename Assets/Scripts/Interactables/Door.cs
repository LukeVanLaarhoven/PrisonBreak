using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public Inventory inventory;

    public Rigidbody rb;
    public HingeJoint hj;

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
            hj.useMotor = true;
        }
    }
}
