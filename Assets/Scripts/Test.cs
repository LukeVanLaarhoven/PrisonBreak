using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        CreateItem();
    }

    public void CreateItem()
    {
        Item key_1 = new Item("Key_1", 5.0f);

        Debug.Log("Name key: " + key_1.GetName() + " Weight key: " + key_1.GetWeight());
    }
}
