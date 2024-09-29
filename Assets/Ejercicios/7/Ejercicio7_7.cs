using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1;   
    [SerializeField] int numero2;   
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 <= numero2)
        {
            for (int i = ++ numero1; i <= numero2; i++)
            {
                Debug.Log("Numero " + i);
            }

        }

        else if (numero2 <= numero1)
        { 
            for(int i = ++ numero2;i <= numero1; i++)
            {
                Debug.Log("Numero " + i);

            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
