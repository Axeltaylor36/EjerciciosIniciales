using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] private int num;
    // Start is called before the first frame update
    void Start()
    {
        bool Primo = Primo2(num);
        if (Primo)
        {
            Debug.Log(num + "  es primo.");
        }
        else  
        Debug.Log(num + "  no es primo.");
        
    }
    bool Primo2(int num1)
    {
        if (num1 <= 1)
        {
            return false;
        }

        for (int i = 2; i <= num1 / 2; i++)
        {
            if (num1 % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}