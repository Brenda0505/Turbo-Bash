using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relogio : MonoBehaviour
{
    public int round = 0;
    Text Text;
    Text Round;
    float Tempo;
    int segundos = 00, minutos = 00;
    [Header("Controlador do Relógio")]
    [Tooltip("Quantidade de minutos limite antes de resetar a cena.")]
    public int Parar = 5;
    public bool ativo = false;

    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()

    {
        if (ativo)

        {
            Tempo += Time.deltaTime * 100;
            if (Tempo > 99)
            {
                segundos++;
                Tempo = 0;
            }
            if (segundos > 59)
            {
                minutos++;
                segundos = 0;
            }

            string minutes = Mathf.Floor((Tempo % 3600) / 60).ToString("00");
            string seconds = (Tempo % 60).ToString("00");
            Text.text = minutos.ToString("00") + ":" + segundos.ToString("00") + ":" + Tempo.ToString("00");

            if (minutos >= Parar)
            {

                if (minutos % 2 == 0)
                {
                    round = minutos / 2;
                }
                if (round == 5)
                {
                    Text.text = "Round " + round.ToString();
                    print("Round - " + round + "------------ GAME OVER");
                    // Application.LoadLevel(Application.loadedLevel);
                    ativo = false;

                }
                else
                {
                    Text.text = "Round " + round.ToString();

                    Tempo = 0;
                    segundos = 00;
                    //minutos = 0;
                    Text.text = minutos.ToString("00") + ":" + segundos.ToString("00") + ":" + Tempo.ToString("00");
                    ativo = true;
                    Debug.Log("Round - " + round);
                }
            }
        }
    }


}