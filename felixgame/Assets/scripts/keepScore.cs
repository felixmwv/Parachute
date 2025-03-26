using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeepScore : MonoBehaviour
{

    public float Score = 0f;   //variabele voor de score
    public int winScore = 64;  //variabele voor de winscore
    TMPro.TMP_Text text; //dit maakt een TextMeshPro text aan




    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>(); 
    }


    void Update()
    {
        if (Score >= winScore) 
        {
            SceneManager.LoadScene(3); //als de score hoger of gelijk is aan de winscore dan wisselt de scene naar het winscherm
        }
        text.text = $"Score: {Score}"; //dit zorgt ervoor dat de score variabele in het ingame ui te zien is
    }
}
