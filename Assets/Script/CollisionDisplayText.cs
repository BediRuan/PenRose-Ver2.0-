using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionDisplayText : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public string message = "Win"; 

    void Start()
    {
        // check message is hidden
        if (messageText != null)
        {
            messageText.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // collision check
        if (collision.gameObject.CompareTag("Target"))
        {
            DisplayMessage();
        }
    }

    void DisplayMessage()
    {
        // Show Message
        if (messageText != null)
        {
            messageText.text = message;
            messageText.gameObject.SetActive(true);
        }
    }
}
