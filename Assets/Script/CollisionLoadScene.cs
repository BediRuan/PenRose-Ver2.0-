using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionLoadScene : MonoBehaviour
{
    public string sceneName = "NextScene"; 

    void OnCollisionEnter(Collision collision)
    {
        // check collision
        if (collision.gameObject.CompareTag("Target"))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        
        SceneManager.LoadScene(sceneName);
    }
}
