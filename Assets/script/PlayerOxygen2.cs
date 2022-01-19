using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;



public class PlayerOxygen2 : CheckCollider
{
    public Slider oxyBar;
    public float OxygenAmount = 100f;
    private float currentOxygen;

    public float division = 2;

    public static bool isUnderWater = false;
    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = OxygenAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnderWater == true)
        {
            currentOxygen += Time.deltaTime;
            if (currentOxygen >= OxygenAmount)
            {
                currentOxygen = OxygenAmount;
            }
            oxyBar.value = (float)currentOxygen / (float)OxygenAmount;
        }
        else
        {
            currentOxygen -= Time.deltaTime / division;
            oxyBar.value = (float)currentOxygen / (float)OxygenAmount;
        }
        if (currentOxygen <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void setUnderWater(bool a)
    {
        isUnderWater = a;
        division = 2;
    }

    public void setOursin()
    {
        division = 30;
    }

}