using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mouseSensativity = 100.0f;
    public float playerMovementSpeed;

    public GameObject mainCamera;

    float xRotation = 0.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensativity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        gameObject.transform.Rotate(Vector3.up * mouseX);
    }

    private void FixedUpdate()
    {
        float movementH = Input.GetAxis("Horizontal") * playerMovementSpeed * Time.deltaTime;
        float movementZ = Input.GetAxis("Vertical") * playerMovementSpeed * Time.deltaTime;

        gameObject.transform.Translate(movementH, 0.0f, movementZ);
    }
}
