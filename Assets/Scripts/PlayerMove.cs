using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float maxSpeed;
    public Rigidbody2D myRigidBody;
    private Vector3 currentScale;
    // Start is called before the first frame update
    void Start()
    {
        currentScale = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)){
            myRigidBody.velocity += Vector2.up * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)){
            myRigidBody.velocity += Vector2.down * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)){
            myRigidBody.velocity += Vector2.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)){
            myRigidBody.velocity += Vector2.right * moveSpeed;
        }
        // velocity should not increase beyond a limit
        if (myRigidBody.velocity.magnitude > maxSpeed)
        {
            myRigidBody.velocity = myRigidBody.velocity.normalized * maxSpeed;
        }
        
        // rotate the player to face the mouse
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Ensure z-coordinate is 0 for 2D calculations
        Vector2 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }
}
