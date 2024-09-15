using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{

    int vidas = 100;
    float exp = 2.5f;

    float multiplicacion;
    float division;
    float porcentaje;
    int dobleVidas;
    float tripleExp;


    void Start()
    {
        Debug.Log("Multiplicacion = " + (multiplicacion = vidas * exp));
        Debug.Log("División = " + (division = vidas / exp));
        Debug.Log("Porcentaje = " + (porcentaje = vidas % exp));
        Debug.Log("Doble vidas = " + (dobleVidas = vidas * 2));
        Debug.Log("Triple exp = " + (tripleExp = exp * 3));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
