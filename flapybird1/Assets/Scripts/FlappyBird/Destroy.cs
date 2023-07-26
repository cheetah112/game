using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform destroyPositionA;
    public Transform destroyPositionB;

    void Update()
    {
        DestroyObject();
    }

    protected void DestroyObject() 
    {
        Collider2D ObjNeedDestroy = Physics2D.OverlapArea(destroyPositionA.position, destroyPositionB.position);
        if(ObjNeedDestroy != null)
        Destroy(ObjNeedDestroy.transform.parent.gameObject);
           
    }
}
