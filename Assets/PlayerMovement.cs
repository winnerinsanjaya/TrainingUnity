using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public Camera mainCamera;

    public float mouseSensitivity = 1f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    void Update()
    {
        Move();
        LookAround();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Debug.Log(moveX + "," + moveY);

        Vector3 direction = new Vector3(moveX, 0, moveY) * speed * Time.deltaTime;
        transform.Translate(direction);
    }

    private void LookAround()
    {
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        Debug.Log(moveX + "," + moveY);

        float yRotation = moveX * mouseSensitivity * Time.deltaTime;
        float xRotation = moveY * mouseSensitivity * Time.deltaTime * 2f;

        xRotation = Mathf.Clamp(xRotation, -45f, 45f);


        transform.Rotate(Vector3.up, yRotation);



        mainCamera.transform.Rotate(Vector3.right, -xRotation);

    }
}
