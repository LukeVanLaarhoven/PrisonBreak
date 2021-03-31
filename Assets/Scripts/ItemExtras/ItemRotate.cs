using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    private void Update()
    {
        gameObject.transform.Rotate(8f * Time.deltaTime, 8f * Time.deltaTime, 0);
    }
}
