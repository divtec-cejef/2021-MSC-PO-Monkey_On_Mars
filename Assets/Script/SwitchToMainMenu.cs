using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToMainMenu : MonoBehaviour
{
    public void playGame()
    {
        //charge la scene du menu de départ (quand on appuiera sur le bouton)
        SceneManager.LoadScene("MenuMain");
    }
}