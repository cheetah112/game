using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Transform firstPos ;
    private Vector3 direction;
    private Rigidbody2D rigid2D;
    public Transform pointLaser;
    public LineRenderer lineLaser;
    public float distanceLaser;
    private float force;
    public Animator animator;
    public bool catIsMoving = false;


    private void Start() {
        rigid2D =GetComponent<Rigidbody2D>();
        firstPos = GameManager.Instance.catFirstPos;
        animator = GetComponent<Animator>();
    }
    private void OnMouseDrag() {
        if(catIsMoving == false){
            Shoot();
        }
    }
    private void OnMouseUp() {
        rigid2D.velocity = direction * force;
        lineLaser.enabled = false;
        catIsMoving = true;
        animator.SetBool("shoot", catIsMoving);
    }
    public void Setup(float force)
    {
        this.force = force;
    }
    private void Shoot(){
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(point.x,Mathf.Clamp(point.y,-5f,GameManager.Instance.catFirstPos.position.y),0);
        direction = (firstPos.position - transform.position);
        direction = new Vector3(direction.x,direction.y,0);
        direction.Normalize(); 
        float angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0,0,angle);
        DrawLaser(direction);    
    }
    private void DrawLaser(Vector3 direction)
    {
        lineLaser.SetPosition(0,pointLaser.position);
        lineLaser.SetPosition(1, direction * distanceLaser);  
    }
}
