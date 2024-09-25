using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField]int kmh;
    float ms;
    //1kmh /3.6 --> ms
    void Start()
    {
        ms = kmh / 3.6f;
        Debug.Log (ms);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
