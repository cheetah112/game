using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
public float cooldown;
public float dame;
public float rangeAttack;
public Transform ShotPos;
public GameObject projecttile;
private float TimeShot = 0;
private Transform enemy;

public void Setup(float dame, float cooldown, float rangeAttack, Transform ShotPos){
    this.dame = dame;
    this.cooldown = cooldown;
    this.rangeAttack = rangeAttack;
    this.ShotPos = ShotPos;
}
private void Update() {
    if(enemy == null) return;
    TimeShot += Time.deltaTime;
    if(TimeShot > cooldown){
        TimeShot = 0;
        SpawnProjecttile();
    }

}
private void SpawnProjecttile(){
    var project = Instantiate(projecttile);
    project.transform.position = ShotPos.position;
    Vector3 direction = (enemy.position - ShotPos.position).normalized;
    float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
    project.transform.eulerAngles = new Vector3(0,0,angle);        
}

public void SetTaget(Transform enemy){
    this.enemy = enemy;
}
private void OnDrawGizmos() {
    Gizmos.DrawWireSphere(ShotPos.position,rangeAttack);
}

}
