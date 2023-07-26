using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float speed;
    public float jumpForce;
    public bool isOnGround;
    private void Update() 
    {
        Movement();
        Jump();
    }
    protected void Movement()
    {
        float dichuyenTraiPhai = Input.GetAxis("Horizontal");
        // transform.position += new Vector3(dichuyenTraiPhai,0,0) * speed * Time.deltaTime;
        myRb.velocity = new Vector2(dichuyenTraiPhai * speed, myRb.velocity.y);
    }
    protected void Jump()
    {
        bool isJumpInput = Input.GetKeyDown(KeyCode.Space);
        if(isJumpInput)
        {
            myRb.velocity += new Vector2(0,jumpForce);
        }
    }
}
