using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farol : MonoBehaviour
{
    public Player_1 pl1;
    public Player_2 pl2;
    public Player_3 pl3;
    public Player_4 pl4;
    public Relogio rl;
   
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
    public void FarolFuncionar ()
    {
        pl1.ativo = true;
        pl2.ativo = true;
        pl3.ativo = true;
        pl4.ativo = true;
        gameObject.SetActive(false);
        rl.ativo = true;
    }


    
}
