using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField]int numero1, numero2;
    int sumaTotal;
    // Start is called before the first frame update
    void Start()
    {
        sumaTotal = SumarTodosLosNumeros(numero1, numero2);
        Debug.Log("La suma total de todos los numeros desde " + numero1 + " hasta " + numero2 + " es " + sumaTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumarTodosLosNumeros(int numero1, int numero2) 
    {
        
        int suma = 0;
        
        
        if(numero1 < numero2) 
        {
            for (int i = numero1; i < numero2; i++) 
            {
                suma = suma + i;
            }
        }
        else if (numero2 < numero1) 
        {
            for (int i = numero2; i < numero1; i++)
            {
                suma = suma + i;
            }
        }
        return suma;
    }
}
