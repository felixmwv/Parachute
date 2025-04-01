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
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
        if (other.CompareTag("floor"))
        {
            Destroy(gameObject);
        }

    }
    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerMovementTwo stats = player.GetComponent<PlayerMovementTwo>();
        stats.moveSpeed *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.moveSpeed /= multiplier;

        Destroy(gameObject);
    }
}