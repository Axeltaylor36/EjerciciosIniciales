using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int numeros = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (numeros >= 1)
        {
            Debug.Log(numeros);
            numeros--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
