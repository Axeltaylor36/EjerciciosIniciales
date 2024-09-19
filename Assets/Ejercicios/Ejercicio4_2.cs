using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{

    [SerializeField] string nombre = "Alejandro", apellido1 = "Sastre", apellido2 = "Gutiérrez";
    [SerializeField] int edad = 20;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ConstruirNombre(nombre, apellido1, apellido2, edad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre (string nombre, string apellido1, string apellido2, int edad)
    {
        string Texto = "La persona se llama " + nombre + apellido1 + apellido2 + " y tiene " + edad + " años de edad";

        return Texto;

    }
}
