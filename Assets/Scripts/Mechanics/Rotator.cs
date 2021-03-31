using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int id;
    public bool open = false;

    public GameObject level;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Interactable";
    }

    private void Update()
    {
        if (open)
        {
            level.transform.rotation = Quaternion.RotateTowards(level.transform.rotation, Quaternion.Euler(0, 90, 0), 30 * Time.deltaTime);
        }
        else
        {
            level.transform.rotation = Quaternion.RotateTowards(level.transform.rotation, Quaternion.Euler(0, 0, 0), 30 * Time.deltaTime);
        }
    }

    public void Open()
    {
        open = !open;

        Debug.Log("Hit");
    }

    public void Action(PlayerManager player)
    {
        if (player.CanOpenDoor(id))
        {
            Open();
        }
    }
}
