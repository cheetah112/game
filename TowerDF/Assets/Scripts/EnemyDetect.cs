using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{
    public Attack attack;
    public List<GameObject> listEnemy;
    private void Update() {
        if(listEnemy.Count == 0){
            attack.SetTaget(null);
            return;
        }
        FindTarget();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
           Debug.Log("1 Enter");
           listEnemy.Add(other.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
           Debug.Log("1 Exit");
           listEnemy.Remove(other.gameObject); 
        }
    }
    private void FindTarget(){
        GameObject target = listEnemy[0];
        attack.SetTaget(target.transform);
    }
}
