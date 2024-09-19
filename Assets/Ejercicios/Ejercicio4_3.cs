using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] float cantidad;
    [SerializeField] string moneda;

    // Start is called before the first frame update
    void Start()
    {
        float conversion = Convertir(cantidad,moneda);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Convertir (float cantidad,string moneda)
    {
        //si quiero de euros a dolares, tendre que multiplicar la cantidad por 0,9. Ya que 1 dolar son 90 centimos
        //y si quiero de dolares a euros, tendre que multiplicar la cantidad por 1,1. Ya que 1 euro son 1,10 dolares

        if (moneda == "euro")
        {
            Debug.Log("Los dolares introducidos son " + cantidad + " euros");



            return cantidad * 0.9f;
        }

        else if (moneda == "dolar")
        {
            Debug.Log("Los euros introducidos son " + cantidad + "dolares");

            return cantidad * 1.1f;
        }

        else

        {
            Debug.Log("Pon una moneda valida, es decir, euro o dolar");
            return cantidad;
        }
    }
}
