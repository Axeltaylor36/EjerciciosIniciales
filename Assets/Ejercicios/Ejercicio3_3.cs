using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField]
    int numero;
   

    int doble, triple;
    // Start is called before the first frame update
    void Start()
    {
        doble = 2 * numero;
        triple = 3 * numero;
        Debug.Log(doble);
        Debug.Log(triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
