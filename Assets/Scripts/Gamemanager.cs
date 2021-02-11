using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    [SerializeField]

    Score score;

    [SerializeField]
    UIAdvice uiAdvice;

    public Score Score { get => score; }
    void Awake()
    {
        if(!instance){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }       
        else
        {
            Destroy(gameObject);            
        }
    }

    public Score GetScore => score;
    
    public UIAdvice GetUIAdvice => uiAdvice;
}
