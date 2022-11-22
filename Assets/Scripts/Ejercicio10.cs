using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{

    public int Year;
    private int result1;
    private int result2;
    private int result3;

    // Start is called before the first frame update
    void Start()
    {
        result1 = Year % 400;
        result2 = Year % 100;
        result3 = Year % 4;

        if(result1 == 0 || result2 == 0 || result3== 0)
        {
            Debug.Log($"{Year} is a leap year.");
        }
        else
        {
            Debug.Log($"{Year} is not a leap year.");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
