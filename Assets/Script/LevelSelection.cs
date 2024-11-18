using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelection : MonoBehaviour
{
    public TextMeshProUGUI levelNameText; 
    public string levelName; 
    public string sceneName; 

    void Start()
    {
        // Hide level name
        if (levelNameText != null)
        {
            levelNameText.gameObject.SetActive(false);
        }
    }

    void OnMouseEnter()
    {
        // show level name
        if (levelNameText != null)
        {
            levelNameText.text = levelName;
            levelNameText.gameObject.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        // Hide level name
        if (levelNameText != null)
        {
            levelNameText.gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        //load scene when click
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
