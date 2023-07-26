using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigid2D;
    public float JumpForce;
    public float JumAngle;
    public float AngleRotateSpeed;


    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.isEndGame) return;
        if(GameManager.Instance.isPauseGame) return;
        bool isTap = Input.GetKeyDown(KeyCode.Space);
        if(isTap) 
        {           
            jump();
        }
        if(GameManager.Instance.isStartGame == false) return;
        if(transform.eulerAngles.z >= (-50f)) RotateBird();
    }
    protected void jump()
    {
        if(GameManager.Instance.isStartGame)
        {
            AudioManager.Instance.PlaySwing();
            rigid2D.velocity = Vector3.up * JumpForce;
            transform.eulerAngles = new Vector3(0,0,JumAngle);
        }
    }
    protected void RotateBird(){
        transform.eulerAngles -= new Vector3(0,0,AngleRotateSpeed * Time.deltaTime);
    }
    
    public void StartGame()
    {
        rigid2D.gravityScale = 1;
    }

}
