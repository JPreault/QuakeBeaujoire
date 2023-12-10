using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Lorsque l'on clique sur le bouton, cela lance le jeu.
    public void OnButtonClickJouer(){
        SceneManager.LoadScene("SampleScene");
    }

    // Lorsque l'on clique sur le bouton, cela quitte l'application
    public void OnButtonClickQuitter(){
        Application.Quit();
    }
}
