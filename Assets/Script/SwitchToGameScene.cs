using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchToGameScene : MonoBehaviour
{
    //initialisation des variables
    public GameObject GroupName;
    public string groupeName;

    public void playGame()
    {
        //récupère la valeur du champ text GroupeName
        groupeName = GroupName.GetComponent<Text>().text;

        //charge la scene de jeu (quand on appuiera sur le bouton)
        SceneManager.LoadScene("GameScene");
    }
}