using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{

    public float Num1;
    public float Num2;
    public string Operation;

    // Start is called before the first frame update
    void Start()
    {
        if(Operation == "sum")
        {
            Debug.Log($"{Num1} + {Num2} = {Num1 + Num2}");
        }
        if(Operation == "subtraction")
        {
            Debug.Log($"{Num1} - {Num2} = {Num1 - Num2}");
        }
        if(Operation == "product")
        {
            Debug.Log($"{Num1} x {Num2} = {Num1 * Num2}");
        }
        if (Operation == "division")
        {
            Debug.Log($"{Num1} : {Num2} = {Num1 / Num2}");
        }
        else
        {
            Debug.Log($"Please, write the name of the operation correctly.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
