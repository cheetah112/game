using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform bagPos;
    public ColorType playerColor;
    public Vector3 GetBagPos(){
        return bagPos.position;
    }
    public void NewBagPos(float y){
        bagPos.position = new Vector3(bagPos.position.x,bagPos.position.y+y,bagPos.position.z);
    }
}
