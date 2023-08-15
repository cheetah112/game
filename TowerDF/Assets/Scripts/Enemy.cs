using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
public float hp;
public float movespeed;
public float dame;
public Movement movement;
private void Start() {
    movement = gameObject.GetComponent<Movement>();
    StartMove();
}
private void StartMove(){
    movement.Setup(movespeed);
}
}
