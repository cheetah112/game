using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorIntroduction : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Vector2 vectorA = new Vector2(0,1);
        Vector3 vectorB = new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position += new Vector3(1,0,0) * speed * Time.deltaTime;
    }
    public void Move(Vector3 steps) {
        this.transform.position += steps * speed * Time.deltaTime;
    }
}
