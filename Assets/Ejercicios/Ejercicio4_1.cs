using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] 
    float radioCirculo = 6f;
    [SerializeField] 
    float baseTriangulo = 8.3f;
    [SerializeField] 
    float altTriangulo = 9f;
    [SerializeField]
    float ladoCuadrado = 2f;

    // Start is called before the first frame update
    void Start()
    {

        float areaCirculo = CirculoArea(radioCirculo);
        Debug.Log("Area del circulo es " + areaCirculo);
        float areaCuadrado = CuadradoArea(ladoCuadrado);
        Debug.Log("Area del cuadrado es " + areaCuadrado);
        float areaTriangulo = TrianguloArea(altTriangulo, baseTriangulo);
        Debug.Log("Area del triangulo es " + areaTriangulo);
    }

    float CirculoArea(float circuloRadio)
    {
        float resultadoCirculo = (circuloRadio * circuloRadio) * MathF.PI;
        return resultadoCirculo;
    }
    float TrianguloArea(float trianguloAltura, float trianguloBase)
    {
        float resultadoTriangulo = trianguloAltura * trianguloBase;
        return resultadoTriangulo;
    }
    float CuadradoArea(float cuadradoLado)
    {
        float resultadoCuadrado = cuadradoLado * cuadradoLado;
        return resultadoCuadrado;
    }


    void Update()
    {
        
    }
}
