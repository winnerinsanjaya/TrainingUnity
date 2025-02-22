using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public float mouseSensitivity = 1f;

    public AnimationTest animationTest;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 thumbAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        if (thumbAxis.magnitude > 0.1f) // Supaya tidak gerak saat stick lepas
        {
            Transform head = Camera.main.transform; // Ambil arah kepala dari kamera utama (CenterEyeAnchor)
            Vector3 forward = head.forward;
            Vector3 right = head.right;

            // Hapus sumbu Y supaya tidak naik-turun
            forward.y = 0;
            right.y = 0;

            // Normalisasi agar gerakan tidak lebih cepat diagonal
            forward.Normalize();
            right.Normalize();

            // Tentukan arah gerakan berdasarkan input stick
            Vector3 moveDirection = forward * thumbAxis.y + right * thumbAxis.x;
            moveDirection *= speed * Time.deltaTime;

            transform.Translate(moveDirection, Space.World);

            // Atur animasi berjalan
            SetAnimBool("IsWalking", true);
        }
        else
        {
            SetAnimBool("IsWalking", false);
        }
    }



    public void SetAnimBool(string name, bool condition)
    {
        animationTest.SetAnimBool(name, condition);
    }



}
