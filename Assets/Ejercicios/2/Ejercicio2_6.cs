using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6: MonoBehaviour
{
    int valor1 = 11; 
    int valor2 = 12; 
    int valor3 = 13;
    int media;
    
    void Start()
    {
        Debug.Log("1era Puntuación = " + valor1 + ". 2a puntuación " + valor2 + (". 3era puntuación " + valor3));
        Debug.Log("Su media es " + (media = (valor1 + valor2 + valor3) / 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
