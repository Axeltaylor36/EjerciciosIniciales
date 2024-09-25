using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{

    [SerializeField] int vidaA; 
    [SerializeField] int vidaB;
  
    // Start is called before the first frame update
    void Start()
    {
        if (vidaA == vidaB)
        {
            Debug.Log("La batalla esta reñida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
