using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // speed

    private float xRotation = 0f; // x angle of rotation
    private float zRotation = 0f;

    void Update()
    {
        // X rotation
        if (Input.GetKey(KeyCode.RightArrow))
        {
            zRotation -= rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            zRotation += rotationSpeed * Time.deltaTime;
        }

        // Z rotation
        if (Input.GetKey(KeyCode.DownArrow))
        {
            xRotation += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            xRotation -= rotationSpeed * Time.deltaTime;
        }

        

        // apply rotation
        transform.rotation = Quaternion.Euler(xRotation, 0f, zRotation);
    }
}