using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCubeBehaviour : MonoBehaviour
{
    public GameObject[] searchLights;
    public GameObject[] nodes;

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

        gameObject.transform.position = Vector3.MoveTowards(transform.position, nodes[ranNode].transform.position, movementSpeed * Time.deltaTime);

        if (timer < 0)
        {
            ranNode = Random.Range(0, nodes.Length);

            timer = 20;
        }
    }
}
