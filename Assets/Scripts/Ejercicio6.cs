using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{

    public float distanceTraveled;
    private float totalDistance = 20;

    // Start is called before the first frame update
    void Start()
    {
        if (distanceTraveled >= 20)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");
        }
        if (distanceTraveled < 20)
        {
            Debug.Log($"Oh... You still have {totalDistance - distanceTraveled} meters left to complete the total distance.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
