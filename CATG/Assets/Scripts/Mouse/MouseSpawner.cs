using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSpawner : MonoBehaviour
{
    public GameObject mouse;
    public float delayPerSpawn;
    private float currentTimeSpawn = 0;
    private void Update() {
        if(GameManager.Instance.isStartGame == false) return;
        if(GameManager.Instance.isEndGame == true) return;
        if (currentTimeSpawn > delayPerSpawn)
        {
            currentTimeSpawn = 0;
            SpawnMouse();
        }
        currentTimeSpawn += Time.deltaTime;
    }
    public void SpawnMouse(){
        Instantiate(mouse);  
    }

}
