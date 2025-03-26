using UnityEngine;

public class PlayerMovementTwo : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private Rigidbody body;
    void Start()
    {
        //Fetches the Rigidbody from the GameObject with this script attached
        body = GetComponent<Rigidbody>();

        //Makes the player spawn in the middle
        transform.position = Vector3.zero;
    }


    void FixedUpdate()
    {
        //Stores user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"),0,0);


        //Applies the movement vector to the current position, which is 
        //multiplied by deltaTime and speed for a smooth MovePosition
        body.MovePosition(transform.position + m_Input * Time.fixedDeltaTime * moveSpeed);
    }
}
