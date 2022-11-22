using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{

    public int Age;

    // Start is called before the first frame update
    void Start()
    {
        if (Age < 18)
        {
            Debug.Log($"Hello, you are {Age} years old, so you are NOT of legal age.");
        }
        if (Age >= 18)
        {
            Debug.Log($"Hello, you are {Age} years old, so you are of legal age.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
