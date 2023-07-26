using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public int speed;
    void Update()
    {
        if(GameManager.Instance.isEndGame) return;
        this.transform.position +=  Vector3.left * speed * Time.deltaTime;    
    }
}
