using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaTotal = 120f;
    

    void Start()
    {
        float turno1 = vidaTotal - (120 * 3 / 100);
            Debug.Log("Ahora tienes " + turno1);
        float turno2 = vidaTotal - (turno1 * 6 / 100);
            Debug.Log("Ahora tienes " + turno2);
        float turno3 = vidaTotal - (turno2 * 9 / 100);
            Debug.Log("Ahora tienes " + turno3);
        float turno4 = vidaTotal - (turno3 * 12 / 100);
            Debug.Log("Ahora tienes " + turno4);
        float turno5 = vidaTotal - (turno4 * 15 / 100);
            Debug.Log("Ahora tienes " + turno5);
    }

    void Update()
    {
        
    }
}
