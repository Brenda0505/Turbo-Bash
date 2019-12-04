using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dano : MonoBehaviour
{
    public Slider barraVida;
    public int vida = 100;
    // Start is called before the first frame update
    void Start()
    {
       // vida = PlayerPrefs.GetInt("danoCarro1");
    }

    // Update is called once per frame
    public void RecebeDano(int danoNovo)
    {
        vida -= danoNovo;
        barraVida.value = vida;
    }
 
}
