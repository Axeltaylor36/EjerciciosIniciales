using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 100;
    float exp = 5.5f;
    char carac = 'e';
    float sumaTotal;
    float restaTotal;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);

        Debug.Log ("Suma Total " + (sumaTotal = vidas + exp));
        Debug.Log ("Resta Total " + (restaTotal = exp - vidas));


        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
