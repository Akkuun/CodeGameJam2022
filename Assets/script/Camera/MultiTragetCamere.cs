using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class MultiTragetCamere : MonoBehaviour
{
    public List<Transform> tragets;
    private Vector3 velocity;
    public float smoothTime = .5f;
    public Vector3 offset;

    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 50f;

    private Camera cam;

     void Start() {
        cam = GetComponent<Camera>();
    }



    void LateUpdate() {
            if(tragets.Count==0){
                return;
            }

        Move();
        Zoom();
    }
void Zoom(){
float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance()/ zoomLimiter);
cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
}
void Move(){
    Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition,ref velocity, smoothTime);
}
float GetGreatestDistance(){
    var bounds = new Bounds(tragets[0].position, Vector3.zero);
    for(int i=0; i< tragets.Count; i++) {
                bounds.Encapsulate(tragets[i].position);
            }
            return bounds.size.x;
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
