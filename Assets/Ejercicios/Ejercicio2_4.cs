using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vida = 50;
    void Start()
    {
        Debug.Log("Vida = " + vida);
        Debug.Log ("Sumamos por 77 = " + (vida = vida + 77));
        Debug.Log ("Restamos por 3 = " + (vida = vida - 3));
        Debug.Log("Cuadriplicamos su valor = " + (vida = vida * 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
