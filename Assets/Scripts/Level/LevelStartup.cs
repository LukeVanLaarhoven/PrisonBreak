using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStartup : MonoBehaviour
{
    public float levelSpeed;

    private void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(0, 0, 0), levelSpeed * Time.deltaTime);
    }
}
