using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje personaje1;
    private bool ejecucion = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ejecucion)
        {
            preparaPersonaje();
            ejecucion = true;
        }
    }

    void preparaPersonaje() 
    {
        Debug.Log(personaje1.Nombre + " tiene un nivel: " + personaje1.CalcularNivel());
    }
}
