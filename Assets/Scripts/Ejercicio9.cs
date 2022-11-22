using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{

    public bool wantsVegetarianOption;

    // Start is called before the first frame update
    void Start()
    {
        if (wantsVegetarianOption == false)
        {
            Debug.Log($"Non-vegetarian option coming soon.");
        }
        else
        {
            Debug.Log($"Vegetarian option ccoming soon");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
