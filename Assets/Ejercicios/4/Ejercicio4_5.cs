using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField]
    float radioCirculo = 6f;
    [SerializeField]
    float baseTriangulo = 8.3f;
    [SerializeField]
    float altTriangulo = 9f;
    [SerializeField]
    float ladoCuadrado = 2f;

    void Start() 
    {
    
    }
    void Calcular()
    {
        float areaCirculo = CirculoArea(radioCirculo);
        float areaTriangulo = TrianguloArea(altTriangulo, baseTriangulo);
        float areaCuadrado = CuadradoArea(ladoCuadrado);
    }

    float CirculoArea(float circuloRadio)
    {
     float resultadoCirculo = (circuloRadio * circuloRadio) * MathF.PI;
        return resultadoCirculo;
    }
    float TrianguloArea(float trianguloAltura, float trianguloBase)
    {
        float resultadoTriangulo = (trianguloAltura * trianguloBase)/2;
        return resultadoTriangulo;
    }
    float CuadradoArea(float cuadradoLado)
    {
        float resultadoCuadrado = (cuadradoLado * cuadradoLado);
        return resultadoCuadrado;
    }
    void Update()
    {

    }

        


}
