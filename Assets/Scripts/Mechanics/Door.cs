using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable
{
    public int id;
    public bool open = false;

    public GameObject door;
    public GameObject level;
    public GameObject endPillar;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Interactable";
    }

    private void Update()
    {
        if (open && id != 2 && id != 5)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, new Vector3(door.transform.position.x, door.transform.position.y + 6, door.transform.position.z), 20f * Time.deltaTime);
        }

        if (open && id == 2)
        {
            level.transform.rotation = Quaternion.RotateTowards(level.transform.rotation, Quaternion.Euler(0, 90, 0), 30 * Time.deltaTime);
        }
        else
        {
            level.transform.rotation = Quaternion.RotateTowards(level.transform.rotation, Quaternion.Euler(0, 0, 0), 30 * Time.deltaTime);
        }

        if (open && id == 5)
        {
            endPillar.transform.Translate(0, 10 * Time.deltaTime, 0);

            Invoke("LoadScene", 10);
        }

        if (open && id == 6)
        {
            Application.Quit();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Open()
    {
        open = !open;
    }

    public void Action(PlayerManager player)
    {
        if (player.CanOpenDoor(id))
        {
            Open();
        }
    }
}
