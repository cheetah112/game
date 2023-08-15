using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> listPos;
    public List<Vector3> GetPath(){
        List<Vector3> listPath = new List<Vector3>();
        for(int i = 0; i < listPos.Count ; i++){
            listPath.Add(listPos[i].position);
        }
        return listPath;
    }
    private void OnDrawGizmos() {
        for(int i = 0; i <listPos.Count -1; i++){
            Gizmos.DrawLine(listPos[i].position,listPos[i+1].position);
        }
    }
}
