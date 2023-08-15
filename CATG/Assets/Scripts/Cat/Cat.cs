using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float force;
    public CatController catController;
    private void Start() {
        catController.Setup(force);
    }
    private void OnBecameInvisible() {
        Destroy(gameObject);
        GameManager.Instance.Reload();
    }
    private void Update() {
        if(GameManager.Instance.isEndGame == true){
            Destroy(gameObject);
        }
    }
}
