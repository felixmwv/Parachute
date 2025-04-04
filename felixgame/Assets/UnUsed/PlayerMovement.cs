using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f; //variabele voor de bewegingssnelheid

    private Rigidbody body; 
    void Start()
    {
        body = GetComponent<Rigidbody>();   //dit roept een Rigidbody op

        transform.position = Vector3.zero;  //dit zorgt ervoor dat het in het midden start
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); //als op a wordt gedrukt, gaat de speler naar links
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); //als op b wordt gedrukt gaat de speler naar rechts
        }
    }
}