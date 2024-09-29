using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 <= numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                string tipo;
                if (i >= 0)
                {
                    tipo = "positivo";
                }
                else 
                    tipo = "negativo";

                string pares;
                if (i % 2 == 0)
                {
                    pares = "par";
                }
                else
                    pares = "impar";

                Debug.Log("El número " + i + " "+ tipo + " "+ pares);

            }

        }

        else
        {
            for (int i = numero2; i <= numero1; i++)
            {
                string tipo;
                if (i >= 0)
                {
                    tipo = "positivo";
                }
                else
                    tipo = "negativo";

                string pares;
                if (i % 2 == 0)
                {
                    pares = "par";
                }
                else
                    pares = "impar";

                Debug.Log("El número " + i + " " + tipo + " " + pares);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
