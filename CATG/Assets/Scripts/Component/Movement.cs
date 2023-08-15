using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{        
    private Path path;
    public List<Path> listPath;
    private float speedMove;
    private Vector3 startPos;
    private Vector3 endPos;
    private int currentPos;
    private List<Vector3> listPos;
    private bool isReach = false;
   
    private void Update() {
        if(isReach == false){
            Move();
        }
    }
    public void Setup(float speed)
    {
        this.speedMove = speed;
        path = listPath[Random.Range(0,listPath.Count-1)];
        listPos = path.GetPath();
        currentPos = 0;
        transform.position = listPos[0];
        startPos = listPos[currentPos];
        endPos = listPos[currentPos +1]; 
    }
    private void Move(){
        Vector3 direction = (endPos - startPos);
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gameObject.transform.eulerAngles = new Vector3(0,0,angle);
        transform.position += direction * speedMove * Time.deltaTime;
        if(Vector3.Distance(transform.position,endPos)<=0.5f){
        gameObject.transform.eulerAngles = new Vector3(0,0,0);
            currentPos ++;
            if(currentPos == listPos.Count - 1){
                isReach = true;
                return;
            }
        }
        startPos = listPos[currentPos];
        endPos = listPos[currentPos +1]; 
    }
}
