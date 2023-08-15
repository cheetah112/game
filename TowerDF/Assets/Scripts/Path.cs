using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> listPosition;
    public List<Vector3> getListPosition()
    {
        List<Vector3> positions = new List<Vector3>();
        for(int i = 0; i < listPosition.Count; i++){
            positions.Add(listPosition[i].position);
        }
        return positions;
    }
    private void OnDrawGizmos(){
        for(int i = 0; i < listPosition.Count - 1 ; i++){
            Gizmos.DrawLine(listPosition[i].position,listPosition[i+1].position);
        }
    }
}
