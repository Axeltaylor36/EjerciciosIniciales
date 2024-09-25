using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10: MonoBehaviour
{
    [SerializeField] int temp;
    // Start is called before the first frame update
    void Start()
    {
        if (temp <= 10)
        {
            Debug.Log("Clima frío");
        }
        else if (10 < temp && temp <= 20)
        {
            Debug.Log("Clima nublado");
        }
        else if (20 < temp && temp <= 30) 
        {
            Debug.Log("Clima caluroso");
        }
        else if (temp > 30) 
        {
            Debug.Log("Clima tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
