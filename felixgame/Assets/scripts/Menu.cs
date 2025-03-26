using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1); //dit wisselt naar scene 1, het level, als op de knop wordt geklikt
    }

    public void Quit()
    {
        Application.Quit(); //dit zorgt ervoor dat het spel afsluit
    }
}
