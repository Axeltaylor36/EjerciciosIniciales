using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        

        if (numero >= 0 && numero <=9)
        {
            Debug.Log(numero + " es un numero comprendido segun la orden exigida");
        }
        else 
        {
            Debug.Log(numero + "no es un numero de los indicados entre el 0 y el 9"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
