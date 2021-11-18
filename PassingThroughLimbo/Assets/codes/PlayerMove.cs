using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float moveSpeed = 100f;
    private float CDT;
    private int maxjumps;
    private bool moveForward;
    //private bool moveBack;
    private bool moveRight;
    private bool moveLeft;
    private bool jump;
    private int MaxSpeed = 35;
    public float speed;
    public float speed_dir;
    private Vector2 oldPosition;

    public Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        speed = Vector2.Distance(oldPosition, transform.position) * 100f;
        speed_dir = (transform.position.x - oldPosition.x);
        oldPosition = transform.position;

        if (MaxSpeed > speed){

            if (moveForward)
            {
                rb.AddForce(new Vector2(0f, moveSpeed));
            }

            //if (moveBack)
			    //rb.AddForce(-moveSpeed * Camera.main.transform.forward.x, 0, -moveSpeed * Camera.main.transform.forward.z);
        
            if (moveLeft)
            {
			    rb.AddForce(new Vector2(-moveSpeed,0));
            }

            if (moveRight)
            {
			    rb.AddForce(new Vector2(moveSpeed,0));
            }
        }

        if (jump){
            rb.AddForce(new Vector2(0,7500f));
            CDT = 0;
        }

        
    }

   void Update()
    {
        moveForward = false;
        //moveBack = false;
        moveLeft = false;
        moveRight = false;
        jump = false;
        if (Input.GetKey("w"))
            moveForward = true;
        if (Input.GetKey("a"))
            moveLeft = true;
        //if (Input.GetKey("s"))
            //moveBack = true;
        if (Input.GetKey("d"))
            moveRight = true;
        if (maxjumps > 0.1)
        {
            if (CDT > 2.9999)
            {
		        if (Input.GetKey("space")){
                    jump = true;
                }
            }
        }

        if (CDT < 3){
            CDT += 0.01f;
        }
    }
}