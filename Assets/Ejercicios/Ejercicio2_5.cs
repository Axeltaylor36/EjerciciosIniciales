using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5: MonoBehaviour
{
    int vidaPlayer1 = 11;
    int vidaPlayer2 = 22;
    int vidaPlayer3 = 33;
    int vidaPlayer4 = 44;

    void Start()
    {
        Debug.Log(vidaPlayer1);
        Debug.Log(vidaPlayer2);
        Debug.Log(vidaPlayer3);
        Debug.Log(vidaPlayer4);

        vidas();

    }

    void vidas()
    {
        vidaPlayer2 = vidaPlayer3;
        vidaPlayer3 = vidaPlayer1;
        vidaPlayer1 = vidaPlayer4;
        vidaPlayer4 = vidaPlayer2; 

        Debug.Log("Vp1 " + vidaPlayer1);
        Debug.Log("Vp2 " +vidaPlayer2);
        Debug.Log("Vp3 " +vidaPlayer3);
        Debug.Log("Vp4 " +vidaPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
