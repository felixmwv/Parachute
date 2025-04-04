using UnityEngine;
using UnityEngine.SceneManagement;
public class DeleteEnemy : MonoBehaviour
{
    //References to the KeepScore and HeartSystem scripts
    public KeepScore Keepscore; 
    public HeartSystem heartSystem; 

    private void OnTriggerEnter(Collider other)
    {
        //Checks if the player or floor is collided with and executes function
        if (other.CompareTag("Player"))
        {
            Keepscore.Score += 1;  
            Destroy(gameObject);  
        }
        if (other.CompareTag("floor"))
        {
            if (heartSystem != null)  
            {
                heartSystem.TakeDamage(1);  
            }
            Destroy(gameObject);  
        }
    }
}
