using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 1.4f;
    public float duration = 4f;

    public GameObject pickupEffect;
    private void OnTriggerEnter(Collider other)
    {
        //Checks if the player or floor is collided with and executes function
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
        else if (other.CompareTag("floor"))
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Pickup(Collider player)
    {
        ISpeedBoost speedboostScript = player.GetComponent<ISpeedBoost>();
        speedboostScript.GainSpeed(multiplier);

        GetComponentInChildren<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        speedboostScript.LoseSpeed(multiplier);

        Destroy(gameObject);
    }
}