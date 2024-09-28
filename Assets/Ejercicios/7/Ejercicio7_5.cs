using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
     while (1 <= numero)
     {
      Debug.Log(numero);
      numero++;
     }

     for (int numFor = 1; numFor <= numero; numFor++)
     {
        Debug.Log(numero);
     }





     // Update is called once per fram

     void Update()
     {

     }
    }
}
