using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int VJugador1;
    [SerializeField] int VJugador2;
    [SerializeField] int VJugador3;
    // Start is called before the first frame update
    void Start()
    {
        if (VJugador1 >= VJugador2 && VJugador1 >= VJugador3)
        {
            Debug.Log("El jugador numero 1 atacará primero con velocidad " + VJugador1);
        }

        else if (VJugador2 >= VJugador1 && VJugador2 >= VJugador3)
        {
            Debug.Log("El jugador numero 2 atacará primero con velocidad " + VJugador2);
        }
        else
        {
            Debug.Log("El jugador numero 3 atacará primero con velocidad " + VJugador3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
