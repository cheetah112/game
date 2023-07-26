using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollison : MonoBehaviour
{
    public Bird bird;
    private void Start() {
        bird = GetComponent<Bird>();        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        GameManager.Instance.EndGame();
        AudioManager.Instance.PlayHit();
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(GameManager.Instance.isEndGame) return;
        if(other.gameObject.tag.Equals("ScoreDetect")) 
        {
            AudioManager.Instance.PlayPoint();
            GameManager.Instance.addScore();
        }
    }
}
