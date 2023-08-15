using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public float timeDestroy;
    private float timeDestroyCurent = 0;
    private void Update() {
        timeDestroyCurent += Time.deltaTime;
        if(timeDestroyCurent >= timeDestroy){
            Destroy(gameObject);
            return;
        }
        transform.position += transform.right * speed * Time.deltaTime;
    }

}
