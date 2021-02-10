using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour, IInteractable
{
    public string itemName;
    public float weight;

    private void Start()
    {
        gameObject.tag = "Interactable";
    }

    public void Action(PlayerManager player)
    {
        if (player.AddItem(CreateItem()))
        {
            RemoveItem();
        }
    }

    public void RemoveItem()
    {
        gameObject.SetActive(false);
    }

    public void Respawnitem()
    {
        gameObject.SetActive(true);
    }

    public abstract Item CreateItem();
}
