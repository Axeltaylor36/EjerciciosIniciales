using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;


    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3 && numero2 <3)
        {
            Debug.Log("Ambos numeros son menores ");
        }
        else
        {
            Debug.Log("Algo va mal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
