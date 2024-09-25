using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] int radio = 8;

    float longitud;
    float area;

    void Start()
    {
        longitud = 2* Mathf.PI *radio;
        area = Mathf.PI * (radio * radio);
        Debug.Log(longitud);
        Debug.Log(area);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
