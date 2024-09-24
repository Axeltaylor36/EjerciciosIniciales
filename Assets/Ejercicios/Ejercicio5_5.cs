using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        float resto = nivel % 2;

        if (resto > 0) 

        {
            Debug.Log("El nivel del perosnae es impar");
        }
        else 
        {
            Debug.Log("El nivel del personaje es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
