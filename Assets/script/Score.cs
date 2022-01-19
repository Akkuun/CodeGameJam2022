using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score = 1;
    public GameObject ScoreText;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = ScoreText.GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = score.ToString();
    }

    
}
