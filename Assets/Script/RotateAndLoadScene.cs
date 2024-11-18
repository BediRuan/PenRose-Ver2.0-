using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateAndLoadScene : MonoBehaviour
{
    public float rotationSpeed = 100f; // set speed
    public string sceneName = "NextScene"; 
    public float targetYRotation = 3.3f; // y axis target
    public float targetXRotation = 10f; // X axis target
    public float tolerance = 1f; // tolerence of targets

    void Update()
    {
        // get player input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // rotate y axis
        if (horizontalInput != 0)
        {
            transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        }

        // rotate x axis
        if (verticalInput != 0)
        {
            transform.Rotate(verticalInput * rotationSpeed * Time.deltaTime, 0, 0);
        }

        // disable z axis change
        Vector3 currentRotation = transform.eulerAngles;
        transform.eulerAngles = new Vector3(currentRotation.x, currentRotation.y, 0);

        // check targets reached
        if (Mathf.Abs(transform.eulerAngles.y - targetYRotation) <= tolerance && Mathf.Abs(transform.eulerAngles.x - targetXRotation) <= tolerance)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // load scene
        SceneManager.LoadScene(sceneName);
    }
}