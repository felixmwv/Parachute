using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeepScore : MonoBehaviour
{
    public float Score = 0f;
    public int winScore = 64;
    TMPro.TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>(); 
    }

    void Update()
    {
        //Switches to win screen if winScore is reached
        if (Score >= winScore) 
        {
            SceneManager.LoadScene(3); 
        }
        //shows the score on screen
        text.text = $"Score: {Score}"; 
    }
}
