using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1); //dit laadt het level als op de knop wordt geklikt
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0); //dit laadt het main menu als op de knop wordt geklikt
    }
}