using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField]float b;
    [SerializeField]float h;
    float area;


    // Start is called before the first frame update
    void Start()
    {
        area = (b * h)/2;
        Debug.Log(area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
