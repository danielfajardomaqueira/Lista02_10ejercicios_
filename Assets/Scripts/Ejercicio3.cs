using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{

    public int Number;
    private int DivisibleNum = 5;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        result = Number % DivisibleNum;

        if (result == 0)
        {
            Debug.Log($"{Number} is divisible by 5");
        }
        else
        {
            Debug.Log($"{Number} is not divisible by 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
