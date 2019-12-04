using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoTraseiro : MonoBehaviour
{
    public int vida;
    public Dano dano;
    // Start is called before the first frame update
    void Start()
        
    {
        
    }

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
