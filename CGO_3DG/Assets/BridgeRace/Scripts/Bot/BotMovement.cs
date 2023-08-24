using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public List<Vector3> listPos;
    public float speed;
    public float radius;
    private Bot bot;
    private void Start() {
        bot = GetComponent<Bot>();
    }
    private void Update() {
       Collider[] listCol = Physics.OverlapSphere(transform.position,radius);
       foreach(var collider in listCol)
       {
        Brick brick = collider.gameObject.GetComponent<Brick>();
        if(brick != null){
            if(brick.brickColor == bot.playerColor)
            {
                listPos.Add(collider.gameObject.transform.position);
            }
        }
       }
       Move();
    }
    private void Move(){
        transform.position += listPos[0] * speed * Time.deltaTime;
    }
    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
