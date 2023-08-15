using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public GameObject cat;
    private void Start() {
    }
    private void Update() {
        if(GameManager.Instance.isEndGame == true) return;
        if(GameManager.Instance.reload == true && GameManager.Instance.isStartGame == true)
        {
            SpawnCat();
            GameManager.Instance.reload = false;
        }
    }
    public void SpawnCat(){
            var catBullet = Instantiate(cat);
            Vector3 catPos = GameManager.Instance.catFirstPos.position;
            catBullet.transform.position = catPos;
        }
}
