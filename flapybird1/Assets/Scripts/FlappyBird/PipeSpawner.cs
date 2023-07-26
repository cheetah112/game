using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
   public GameObject pipeCopy;
   public float delayPerSpawn;
   public Transform spawnPosition;
   public Transform spawnPositionMin;
   public Transform spawnPositionMax;
   private float currentTimeSpawn = 0;

    void Update()
    {
        if(GameManager.Instance.isStartGame == false) return;
        if(GameManager.Instance.isEndGame) return;
        if(currentTimeSpawn > delayPerSpawn)
        {
            GameObject pipe = Instantiate(pipeCopy);
            var Objposition = new Vector3(spawnPosition.position.x,Random.Range(spawnPositionMin.position.y,spawnPositionMax.position.y),spawnPosition.position.z);
            pipe.transform.position = Objposition;
            currentTimeSpawn = 0;
        }
        currentTimeSpawn += Time.deltaTime;
    }

}
