﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    public float yMovimento;
    public float xMovimento;
    public bool ativo = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        float movimento = Input.GetAxis("HorizontalCarro2");
 //       Debug.Log(movimento);

        float movimento2 = Input.GetAxis("VerticalCarro2");
//        Debug.Log(movimento2);

        if (ativo)
        {
            // if (movimento < 0 || movimento > 0)
           // Debug.Log(movimento2 * xMovimento * Time.deltaTime * transform.right);
            GetComponent<Rigidbody2D>().AddForce(movimento2 * xMovimento * Time.deltaTime * transform.right);

            //if (movimento2 < 0 || movimento2 > 0)
            // GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, movimento2 * yMovimento);

            transform.Rotate(movimento * yMovimento * Time.deltaTime * transform.forward);

            //alterar flip
            if (movimento < 0)
            {
                // GetComponent<SpriteRenderer>().flipX = true;
            }



            else if (movimento > 0)
            {
                // GetComponent<spriteRenderer>
            }
        }
    }
}
