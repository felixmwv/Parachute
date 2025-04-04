using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class HeartSystem : MonoBehaviour
{
    public List<GameObject> hearts = new List<GameObject>();    
    public int life;               
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
        //d is damage taken, if life reaches 0 scene will switch to game over screen
        life -= d;   
        if(life <= 0)
        {
            SceneManager.LoadScene(2); 
        }
        //Shows and hides how many hearts are left
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

    public void GainHealth(int h)
    {
        //Adds an extra heart
        life += h;

        for (int i = hearts.Count; i < life; i++)
        {
            GameObject heart = Instantiate (heartPrefab, heartHolder);  hearts.Add(heart);
        }
    }
    
}
