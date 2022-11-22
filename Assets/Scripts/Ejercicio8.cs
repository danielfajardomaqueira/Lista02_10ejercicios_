using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{


    public int Points;
        
    // Start is called before the first frame update
    void Start()
    {
        if (Points > 100)
        {
            Debug.Log($"You have more than 100 points.");
        }
        if (Points <= 100 && Points >= 75)
        {
            Debug.Log($"You have more than 75 points, but less than or equal to 100");
        }
        if (Points <= 75 && Points >= 50)
        {
            Debug.Log($"You have more than 50 points, but less than or equal to 75");
        }
        if (Points <= 50 && Points >= 25)
        {
            Debug.Log($"You have more than 25 points, but less than or equal to 50");
        }
        if (Points <= 25)
        {
            Debug.Log($"You have less than or equal 25 points");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
