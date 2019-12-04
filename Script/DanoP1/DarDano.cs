using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarDano : MonoBehaviour
{
    public int vida;
    public Dano dano;

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //dano.dano += vida;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Parou de Colidir");
    }

    
}
