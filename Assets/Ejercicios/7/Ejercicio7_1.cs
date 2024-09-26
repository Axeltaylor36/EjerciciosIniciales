using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{

    int numeros;

    // Start is called before the first frame update
    void Start()
    {
        while (numeros <= 100) 
        {
            Debug.Log(numeros);
            numeros++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
