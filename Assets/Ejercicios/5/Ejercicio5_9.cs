using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField]int tipoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        int vida, da�o;
        if (tipoEnemigo ==1)
        {
            da�o = 350;
            vida = 650;

            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==2) 
        {
            da�o = 300;
            vida = 550;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==3)
        {
            da�o = 300;
            vida = 500;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==4)
        {
            da�o = 310;
            vida = 460;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
        }
        else if (tipoEnemigo ==5)
        {
            da�o = 280;
            vida = 490;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
        }
        else if(tipoEnemigo ==6)
        {
            vida = 360;
            da�o = 520;
            Debug.Log("El enemigo " + tipoEnemigo + " tiene de da�o y vida base " + da�o + " de da�o y de vida tiene " + vida);
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
