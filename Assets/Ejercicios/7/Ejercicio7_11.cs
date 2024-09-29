using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++) 
        {
            int multiplo = num * i;
            Debug.Log(i + " * " + num + " = " +  multiplo);
        }
    }

    // Update is called once per frame
    void Update()

    {
        
    }
}
