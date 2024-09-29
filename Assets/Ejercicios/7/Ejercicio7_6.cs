using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;
    
    // Start is called before the first frame update
    void Start()
    {
        estructuraFor();
        estructuraWhile();
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    void estructuraFor()
    {
        for (int i = num; i <= -num ; i--) 
        {
            Debug.Log("Estructura FOR = " + i);
        }
    }


    void estructuraWhile()
    {
        int i = num;
        while (i >= -num)
        {
            Debug.Log("Estructura WHILE = " + i);
            i--;
        }

    }
}
