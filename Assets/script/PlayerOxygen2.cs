using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class PlayerOxygen2 : CheckCollider
{
    public Slider oxyBar;
    public float OxygenAmount = 100f;
    private float currentOxygen;

    public static bool isUnderWater = false;
    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = OxygenAmount;
    }

    // Update is called once per frame
     void Update() {
         if(isUnderWater==true){
             currentOxygen += Time.deltaTime;
             if(currentOxygen >= OxygenAmount){
                 currentOxygen = OxygenAmount;
             }
                     oxyBar.value = (float)currentOxygen/(float)OxygenAmount;
         }
         else{
        currentOxygen -= Time.deltaTime/2;
        oxyBar.value = (float)currentOxygen/(float)OxygenAmount;
         }
         if(currentOxygen <= 0){
             print("Tu est mort");
         }
     }

     public void setUnderWater(bool a) {
         isUnderWater= a;
     }
    
}