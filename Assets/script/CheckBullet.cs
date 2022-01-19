using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBullet : MonoBehaviour
{
public static int nbItem = 7;
private static int nb1 = 0;
private static int nb2 = 0;

 AudioSource myaudio;
  bool m_toogle;

 void Start() {
        myaudio = GetComponent<AudioSource>();
        m_toogle = false;
     }
 

private void Update() {
    print(nbItem);
    if(nbItem <= 1){
        Debug.Log("AAAAAAA");
            if(nb1>nb2){
                    print("Player 1 WIN");
            }
            else if ( nb1<nb2){
                print("Player 2 WIN");
                }
                else
                {
                    print("Egaliter");
                }
            
        }
}
private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
        Destroy(this);
        GetComponent<Renderer>().enabled = false;
        other.gameObject.GetComponent<Score>().score++;
        nbItem--; nb1++;
        myaudio.Play(); 
        m_toogle = true;

        }
        if(other.CompareTag("Player2")){
        Destroy(this);
        GetComponent<Renderer>().enabled = false;
        other.gameObject.GetComponent<Score2>().score++;
                nbItem--; nb2++;
                myaudio.Play(); 
                m_toogle = true;
        }

        
        // }
    }
}