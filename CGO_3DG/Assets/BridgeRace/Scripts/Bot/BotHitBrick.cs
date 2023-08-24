using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHitBrick : MonoBehaviour
{
    private Bot player;
    private void Start() {
        player = GetComponent<Bot>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Brick")){
            var brick = other.GetComponent<Brick>();
            if(brick != null){
                if(brick.brickColor == player.playerColor){
                    other.gameObject.transform.parent = gameObject.transform;
                    other.gameObject.transform.position = player.GetBagPos();
                    other.enabled = false;
                    player.NewBagPos(0.2f);
                }
            }
        }
    }
}
