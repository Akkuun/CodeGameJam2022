using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
                other.gameObject.GetComponent<PlayerOxygen>().setUnderWater(true);
        }
        if(other.CompareTag("Player2")){
                other.gameObject.GetComponent<PlayerOxygen2>().setUnderWater(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
                other.gameObject.GetComponent<PlayerOxygen>().setUnderWater(false);
        }
        if(other.CompareTag("Player2")){
                other.gameObject.GetComponent<PlayerOxygen2>().setUnderWater(false);
        }
    }
}
