using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Path path;
    private List<Vector3> Path = new List<Vector3>();
    private float speed;
    private int currentPos;
    private Vector3 startPos;
    private Vector3 endPos;
    private bool isReach = false;
    
    private void Update() {
        if(isReach == false){
            Move();
        }
    }
    public void Move(){
        Vector3 direction = (endPos - startPos).normalized;
        transform.position += direction * speed * Time.deltaTime;
        if(Vector3.Distance(transform.position, endPos) <= 0.05f){
            currentPos ++;
            if(currentPos == Path.Count-1){
                isReach = true;
                return;
            }
            startPos = Path[currentPos];
            endPos = Path[currentPos+1];
        }
    }
    public void Setup(float movespeed){
        this.speed = movespeed;
        Path = path.getListPosition();
        currentPos = 0;
        startPos = Path[currentPos];
        endPos = Path[currentPos+1];
        transform.position = startPos; 
    }
}
