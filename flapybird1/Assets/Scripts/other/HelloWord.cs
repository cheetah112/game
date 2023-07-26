using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWord : MonoBehaviour
{
   private void Awake()
   {
        Debug.Log("Awake is called");
   }

   private void OnEnable()
   {
        Debug.Log("OnEnable is called");
   }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is called");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update is calling");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable is called");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy is called");
    }
}
