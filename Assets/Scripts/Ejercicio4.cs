using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{

    public float Base;
    public float Height;
    private float result;

    // Start is called before the first frame update
    void Start()
    {
        result = (Base * Height) / 2;
        if(result > 0)
        {
            Debug.Log($"The area with base {Base} and height {Height} is {result}");
        }
        if(result < 0)
        {
            Debug.Log($"The area cannot be calculated");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
