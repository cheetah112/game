using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Transform FB;
    private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag.Equals("Mouse")){
            GameManager.Instance.AddScore();
            SpawnEffect(gameObject.transform);
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameManager.Instance.Reload();
        }
   }
    private void SpawnEffect(Transform Pos){
        GameObject particle = Resources.Load<GameObject>("Explosion");
        if(particle != null){
            GameObject explor = Instantiate(particle);
            explor.transform.position = Pos.position;
            Destroy(explor.gameObject, 1);
        }
    }
}
