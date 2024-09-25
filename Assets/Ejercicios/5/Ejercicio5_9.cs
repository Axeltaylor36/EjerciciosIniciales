using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField]int tipoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        int vida, daño;
        if (tipoEnemigo ==1)
        {
            daño = 350;
            vida = 650;

            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==2) 
        {
            daño = 300;
            vida = 550;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==3)
        {
            daño = 300;
            vida = 500;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==4)
        {
            daño = 310;
            vida = 460;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==5)
        {
            daño = 280;
            vida = 490;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }
        else if(tipoEnemigo ==6)
        {
            vida = 360;
            daño = 520;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de daño y vida base " + daño + " de daño y de vida tiene " + vida);
        }

        else 
        {
            Debug.Log("Solo estan los enemigos disponibles entre el 1 y el 6");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
