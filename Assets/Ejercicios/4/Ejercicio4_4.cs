using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float velocidadKmH;

    void Start()
    {
        float metrossegundos = Conversor(1000, 3600);

        Debug.Log(velocidadKmH + "Km/H son " + metrossegundos +" metros por segundo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    float Conversor (float metros, float segundos)
    {
        //1Km/1h = 1000m / 3600 segundos
        float transformVelocidad = velocidadKmH / metros * segundos;
        return transformVelocidad;
    }

}
