using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIAdvice : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI messageContent;
    [SerializeField]
    Image borderImage;
    float timer = 0f;
    [SerializeField, Range(0.1f, 5f)]
    float timeLimit = 0.5f;
    public void SetBorderColor(Color color)
    {
        borderImage.color = color;
    }

    public void SetMessageContent(string messaje)
    {
        messageContent.text = message;
    }

    public InitAdvice(Color color, string message)
    {
        borderImage.color = color;
        messageContent.text = message;
        gameObject.SetActive(true);
        timer = 0f;
    }

    void Update()
    {
        timer += time.deltaTime;

        if(timer >= timeLimit)
        {
            timer = 0f;
            gameObject.SetActive(false);
        }
    }
    
}
