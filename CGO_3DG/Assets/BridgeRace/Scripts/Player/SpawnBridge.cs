using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBridge : MonoBehaviour
{
    public GameObject prefabBridge;
    public Transform bridgeSpwanPos;
    private MeshRenderer mRenderer;
    private float z;
    private Player player;
    private void Start() {
        mRenderer = prefabBridge.GetComponent<MeshRenderer>();
        z = mRenderer.bounds.size.z;
        player = GetComponent<Player>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("bridgePos")){
            for(int i = player.transform.childCount -1; i >= 0; i--){
                Transform child = player.transform.GetChild(i);
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
        player.NewBagPos(-0.2f);
    }
}
