using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        //Scene switches to the game
        SceneManager.LoadScene(1); 
    }

    public void RestartGame()
    {
        //Scene switches to main menu
        SceneManager.LoadScene(0); 
    }
}