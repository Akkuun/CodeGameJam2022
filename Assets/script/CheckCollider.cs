using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
        AudioSource myaudio; 
        bool m_toogle;
    // Start is called before the first frame update
    void Start()
    {
        myaudio = GetComponent<AudioSource>();
        m_toogle = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
                other.gameObject.GetComponent<PlayerOxygen>().setUnderWater(true);
                myaudio.Play(); 
                m_toogle = true; 
                
        }
        if(other.CompareTag("Player2")){
                other.gameObject.GetComponent<PlayerOxygen2>().setUnderWater(true);
                 myaudio.Play(); 
                m_toogle = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
                other.gameObject.GetComponent<PlayerOxygen>().setUnderWater(false);
                m_toogle = false;
        }
        if(other.CompareTag("Player2")){
                other.gameObject.GetComponent<PlayerOxygen2>().setUnderWater(false);
                m_toogle = false;
        }
    }
}
