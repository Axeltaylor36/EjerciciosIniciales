using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    string nombrePersonaje = "Roger";
    bool veneno = false;
    float porcentajeAcierto =43.7f;
    char solucionPuzzle = 'C';
    int resultado = 3;
    int danhoEnemigo = 20;
    int pocion = 15;
    
    
    int danho = 37;
    int vidas = 100;
    // Start is called before the first frame update
    void Start()
    {
        vidas = vidas / danho;
        Debug.Log("Hola " + nombrePersonaje + "bienvenido a mi mundo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Adiós mundo:");
    }
}
