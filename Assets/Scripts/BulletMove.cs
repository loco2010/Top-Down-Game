using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D myRigidBody;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet whereever it is facing
        myRigidBody.velocity = transform.right * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.layer == 8 || other.gameObject.layer == 6){
            Destroy(self);
        }

    }
}
