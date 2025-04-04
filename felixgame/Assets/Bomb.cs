using UnityEngine;

public class Bomb : MonoBehaviour
{
    //References HeartSystem script
    public HeartSystem heartSystem;
    private void OnTriggerEnter(Collider other)
    {
        //Checks if the player or floor is collided with and executes function
        if (other.CompareTag("Player"))
        {
            if (heartSystem != null)
            {
                heartSystem.TakeDamage(3); 
            }
            Destroy(gameObject);
        }
        else if (other.CompareTag("floor"))
        {
            Destroy(gameObject);
        }
    }
}
