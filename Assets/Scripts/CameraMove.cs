using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidBody;
    public Rigidbody2D playerRigidBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.MovePosition(new Vector2(playerRigidBody.position.x, playerRigidBody.position.y));
    }
}
