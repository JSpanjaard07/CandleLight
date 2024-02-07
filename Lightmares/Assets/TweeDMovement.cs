using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweeDMovement : MonoBehaviour
{

     //Movement
    public float speed;
    public float updownspeed;
    float moveVelocity;
    float updownVelocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    

        moveVelocity = 0;
        updownVelocity = 0;

        //Left Right Movement
        if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) 
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) 
        {
            moveVelocity = speed;
        }
         if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            updownVelocity = updownspeed;
        }
         if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            updownVelocity = -updownspeed;
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (updownVelocity, GetComponent<Rigidbody2D> ().velocity.x);


    }

}
