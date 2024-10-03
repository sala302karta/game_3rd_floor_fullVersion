using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;

    void Start()
    {
        //Celownik zablokowany na srodku i niewidzialny kursor
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {
        //Getting the mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Rotation around the X axis(up/down)
        xRotation -= mouseY;

        //Clamp the rotation
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);
        //Rotation around the Y axis(left/right)
        yRotation += mouseX;

        //Apply rotation to transform
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);


    }
}
