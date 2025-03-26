using UnityEngine;
using UnityEngine.SceneManagement;
public class DeleteEnemy : MonoBehaviour
{

    public KeepScore Keepscore; //dit is een referentie naar het KeepScore script
    public HeartSystem heartSystem; //dit is een referentie naar het HeartSystem script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Keepscore.Score += 1;  // 1 punt score erbij als de player geraakt wordt
            Destroy(gameObject);  //als het object met de tag player geraakt wordt, wordt het verwijderdt
        }
        if (other.CompareTag("floor"))
        {
            if (heartSystem != null)  
            {
                heartSystem.TakeDamage(1);  //als de vloer geraakt wordt krijgt de player damage
            }
            Destroy(gameObject);  //en wordt het object verwijdert
        }
    }
}
