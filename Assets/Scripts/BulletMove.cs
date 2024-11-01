using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D myRigidBody;
    public GameObject self;
    public float lifeTime;
    private float spawnTime;
    public bool canTouchWall;

    // Start is called before the first frame update
    void Start(){
        spawnTime = Time.time;
    }
        

    // Update is called once per frame
    void Update()
    {
        // Move the bullet whereever it is facing
        myRigidBody.velocity = transform.right * moveSpeed;
        if (Time.time > spawnTime + lifeTime){
            Destroy(self);
        }
    }

   
    private void OnCollisionEnter2D(Collision2D other){
        if(!canTouchWall){
            if (other.gameObject.layer == 8 || other.gameObject.layer == 6){
                Destroy(self);
            }
        }

    }
}
