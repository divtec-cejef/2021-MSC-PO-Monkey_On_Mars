using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchToMenu : MonoBehaviour
{

    public void returnMenu()
    {

        //charge la scene de jeu (quand on appuiera sur le bouton)
        SceneManager.LoadScene("MenuMain");

        
    }
}