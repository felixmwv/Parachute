using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;    //dit zijn de harten in het ui
    public int life;               //variabele voor levens

    void Update()
    {
        if(life < 1)
        {
            Destroy(hearts[0].gameObject);  //als een leven eraf gaat, wordt een hart uit het ui verwijderd
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);  //als een leven eraf gaat, wordt een hart uit het ui verwijderd
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);  //als een leven eraf gaat, wordt een hart uit het ui verwijderd
        }
        if (life <= 0)
        {
            SceneManager.LoadScene(2); //als de levens op zijn, wisselt het spel naar het game over scherm
        }
    }

    public void TakeDamage(int d)
    {
        life -= d;   //d is hoeveel damage er gedaan wordt
    }
}
