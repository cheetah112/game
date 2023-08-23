using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBridge : MonoBehaviour
{
    public GameObject prefabBridge;
    public Transform bridgeSpwanPos;
    private Collider collider;
    private float z;
    private void Start() {
        collider = GetComponent<Collider>();
        z = collider.bounds.size.z;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Play")){
            Debug.Log("enter");
            for(int i = 0 ; i < other.transform.childCount; i++){
                Transform child = other.transform.GetChild(i);
                if(child.CompareTag("Brick")){
                    Destroy(child.gameObject);
                    SpwanBridgeP();
                    break;
                }
            }
        }
    }
    public void SpwanBridgeP(){
        var bridgeP = Instantiate(prefabBridge);
        bridgeP.transform.position = new Vector3 (bridgeSpwanPos.position.x,bridgeSpwanPos.position.y,bridgeSpwanPos.position.z + z);
        bridgeSpwanPos.position = bridgeP.transform.position;
    }
}
