using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagementLight : MonoBehaviour
{

    public Light soleil;
    public int s1;
    public int s2;

    private void Start()
    {
        soleil = GetComponent<Light>();
        s1 = CheckBullet.nbItem;
    }

    void Update()
    {
        s2 = CheckBullet.nbItem;

        if (s2 < s1)
        {
            soleil.intensity += .25f;
            s1 = s2;
        }

    }
}