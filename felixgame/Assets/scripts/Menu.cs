using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        //Starts the game
        SceneManager.LoadScene(1); 
    }

    public void Quit()
    {
        //Closes the game
        Application.Quit(); 
    }
}
