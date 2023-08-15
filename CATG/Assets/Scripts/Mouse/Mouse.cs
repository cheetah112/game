using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float speed;
    public Movement move;
    private void Start() {
        move.Setup(speed);
    }
    private void Update() {
        DestroyAll();
    }
    private void DestroyAll()
    {
        if(GameManager.Instance.isEndGame == true)
        {
            Destroy(gameObject);
        }
    }
}
