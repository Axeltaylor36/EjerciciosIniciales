using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{

    [SerializeField] int numero1;
    [SerializeField] int numero2;
    
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 != 0)
        {
            float division = numero1 / numero2;
            Debug.Log(division + "es el resultado de la división");
        }
        else 
        {
            Debug.Log("No se puede dividir entre cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
