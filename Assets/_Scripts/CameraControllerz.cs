using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerz : MonoBehaviour
{
    [SerializeField] Transform player;
    public float mouseSensitivity;

    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;

        Vector3 rotPlayer = player.transform.rotation.eulerAngles;

        rotPlayer.x -= rotAmountY;
        rotPlayer.z = 0;
        rotPlayer.y += rotAmountX;
        player.rotation = Quaternion.Euler(rotPlayer);

    }
}