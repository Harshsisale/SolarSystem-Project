using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

public class FpsController : MonoBehaviour
{
    public float sensitivity;
    public float slowspeed, normalSpeed, fastSpeed;
    float currentSpeed;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Movement();
            Rotation();
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Rotation()
    {
        Vector3 mouseInput = new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0);
        transform.Rotate(-mouseInput * sensitivity * Time.deltaTime * 50);
        Vector3 eulerRotation = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
    }

    void Movement()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = fastSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            currentSpeed = slowspeed;
        }
        else
        {
            currentSpeed = normalSpeed;
        }

        // Move normally
        transform.Translate(input * currentSpeed * Time.deltaTime);

        // Move up when spacebar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * slowspeed * Time.deltaTime);
        }
          if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.down * slowspeed * Time.deltaTime);
        }
    }
}
