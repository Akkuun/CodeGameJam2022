using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTragetCamere : MonoBehaviour
{
    public List<Transform> tragets;
    public Vector3 offset;

    void LateUpdate() {
            if(tragets.Count==0){
                return;
            }

        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = newPosition;
    }

        Vector3 GetCenterPoint(){
            if(tragets.Count == 1){
                return tragets[0].position;
            }

            var bounds = new Bounds(tragets[0].position, Vector3.zero);
            for(int i=0; i< tragets.Count; i++) {
                bounds.Encapsulate(tragets[i].position);
            }
            return bounds.center;
        }
}
