using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    [SerializeField]  private string nombre;
    [SerializeField]  private float vida;
    [SerializeField]  private float exp;

    public string Nombre { get => nombre; set => nombre = value; }

    // Start is called before the first frame update
    void Start()
    {
        CalcularNivel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float CalcularNivel ()
    {
        float lvl = exp / 1000f;

        return lvl;
    }
}
