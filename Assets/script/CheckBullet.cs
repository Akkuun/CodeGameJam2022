using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBullet : MonoBehaviour
{

private void OnTriggerEnter2D(Collider2D other) {
    // if(Input.GetKeyDown(KeyCode.E)){
        if(other.CompareTag("Player")){
        Destroy(this);
        GetComponent<Renderer>().enabled = false;
        other.gameObject.GetComponent<Score>().score++;
        }
        if(other.CompareTag("Player2")){
        Destroy(this);
        GetComponent<Renderer>().enabled = false;
        other.gameObject.GetComponent<Score2>().score++;
        }
        // }
    }
}