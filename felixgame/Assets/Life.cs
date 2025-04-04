using UnityEngine;

public class Life : MonoBehaviour
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
                heartSystem.GainHealth(1);
            }
            Destroy(gameObject);
        }
        else if (other.CompareTag("floor"))
        {
            Destroy(gameObject);
        }
    }
}
