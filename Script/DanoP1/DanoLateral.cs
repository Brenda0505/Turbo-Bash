using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoLateral : MonoBehaviour
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
        print(collision.collider.name);
        if (collision.collider.name == "DarDano")
        {
            dano.RecebeDano(vida);
        }
    }
    
}
