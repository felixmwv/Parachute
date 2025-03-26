using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class HeartSystem : MonoBehaviour
{
    public List<GameObject> hearts = new List<GameObject>();    //dit zijn de harten in het ui
    public int life;               //variabele voor levens
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private Transform heartHolder;

    private void Start()
    {
        for (int i = 0; i < life; i++)
        {
            GameObject heart = Instantiate(heartPrefab, heartHolder);
            hearts.Add(heart);
        }
    }
    public void TakeDamage(int d)
    {
        life -= d;   //d is hoeveel damage er gedaan wordt
        if(life <= 0)
        {
            SceneManager.LoadScene(2); //als de levens op zijn, wisselt het spel naar het game over scherm
        }
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < life)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
            {
                hearts[i].gameObject.SetActive(false);
            }
        }
    }
}
