using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public float Number;

    // Start is called before the first frame update
    void Start()
    {
        if (Number < 0)
        {
            Debug.Log($"{Number} is a negative number");
        }
        if (Number > 0)
        {
            Debug.Log($"{Number} is a positive number");
        }
        if (Number == 0)
        {
            Debug.Log($"{Number} is Zero");
        }
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
