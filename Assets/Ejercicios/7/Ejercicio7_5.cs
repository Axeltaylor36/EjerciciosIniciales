using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        estructuraFor();
        estructuraWhile();
    }
     // Update is called once per fram
     void Update()
     {

     }

     void estructuraWhile() 
     {
        int i = 0;
        while (i <= numero)
        {
            Debug.Log("Estructura WHILE = " + i);
            i ++;
        }
     } 
    void estructuraFor()
    {
        for (int i = 1; i <= numero; i++)
        {
            Debug.Log("Estructura FOR = " + i);
        }
    }
}
