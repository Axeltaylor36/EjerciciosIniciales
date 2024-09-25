using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int h;
    [SerializeField] int m;
    [SerializeField] int s;

    // Start is called before the first frame update
    void Start()
    {
        if (h > 24 || m > 60 || s > 60) 
        {
            Debug.Log("La hora es invalidad, porfavor coloque una hora correcta");
        }
        else 
        {
            Debug.Log("Son las " +  h + " horas " + m + " minutos " + s + " y segundos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
