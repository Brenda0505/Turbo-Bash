using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   
   

    public void ProximochamaRascunho()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Rascunho jogo corrida");

    }

    public void CreditoschamaCreditos()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Creditos");

    }
    public void ComojogarchamaTutorial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");

    }

        public void VoltarchamaCenasAnteriores()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene( "Menu rascunho");

    }
    public void VoltarchamaCenasanterior()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");

    }
    public void Engrenagemchamaconfiguraco()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Configuracoes");

    }
    public void Sair()
    {
        Application.Quit();
    }
}
