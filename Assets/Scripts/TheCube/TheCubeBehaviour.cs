using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCubeBehaviour : MonoBehaviour
{
    public GameObject[] searchLights;
    public GameObject[] nodes;
    public GameObject player;

    private float ranNum;
    private int ranNode;
    public float movementSpeed;
    private float timer;

    private void Start()
    {
        ranNum = Random.Range(-7, 7);

        timer = 0;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        searchLights[0].transform.Rotate(Vector3.up * Time.deltaTime * ranNum, Space.World);
        searchLights[1].transform.Rotate(Vector3.up * Time.deltaTime * ranNum, Space.World);
        searchLights[2].transform.Rotate(Vector3.up * Time.deltaTime * ranNum, Space.World);
        searchLights[3].transform.Rotate(Vector3.up * Time.deltaTime * ranNum, Space.World);

        gameObject.transform.Rotate(0, 1.2f * Time.deltaTime, 0);

        if (ranNode <= nodes.Length)
        {
            if (ranNode > nodes.Length)
            {
                ranNode -= 1;
            }

            gameObject.transform.position = Vector3.MoveTowards(transform.position, nodes[ranNode].transform.position, movementSpeed * Time.deltaTime);
        }

        if (ranNode == nodes.Length + 1)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, gameObject.transform.position.y, player.transform.position.z), movementSpeed * Time.deltaTime);
        }

        if (timer < 0)
        {
            ranNode = Random.Range(0, nodes.Length + 1);

            timer = 30;
        }
    }
}
