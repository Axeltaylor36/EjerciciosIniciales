using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;

    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 10 == 0)    
        {
            Debug.Log("¡Vaya! Este pokemon ha aprendido un nuevo ataque");
        }    

        else 
        {
            Debug.Log("Sigue combatiendo para aumentar el nivel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
