using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rigid;
    public float jumpForce = 10;
    public float newSpeed = 20;
    public bool isJump = false;
    float mouseSensitivity = 100f;
    void Update()
    {
        SetSpeed(newSpeed);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isJump == false) Jump();
        }
        if(rigid.velocity.y == 0){
            isJump = false;
        }
        float xLeftRight = Input.GetAxis("Horizontal");
        float zForwardbackward = Input.GetAxis("Vertical");
        Vector3 move = transform.right * xLeftRight + transform.forward * zForwardbackward;
        transform.position += move * speed * Time.deltaTime;
    }
    private void Jump()
    {
        rigid.velocity += new Vector3(0,jumpForce,0);
        isJump = true;
    }
    private void SetSpeed(float newSpeed)
    {
        if(Input.GetKey(KeyCode.RightShift))
        {
            speed = newSpeed;
        }else{
            speed = 10;
        }
    }
    private void Rotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}
