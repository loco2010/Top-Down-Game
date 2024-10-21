using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.velocity = transform.up * maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnCollisionEnter2D(Collision2D other)
{
    // print a random number between 0 and 360 inclusive of both
    int randomNumber = Random.Range(0, 361);
    transform.Rotate(0, 0, randomNumber);
    // make it go forward
    myRigidBody.velocity = transform.up * maxSpeed;
}
}
