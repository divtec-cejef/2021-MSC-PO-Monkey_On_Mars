using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StardEndMenu : MonoBehaviour
{
    //initialisation des variables
    public GameObject monkey;

void Update()
    {
        //si le singe arrive à la bonne position "sur la plateforme"
        if (monkey.transform.position.x > -1.3 && monkey.transform.position.x < 1.7 && monkey.transform.position.y > 11.32 && monkey.transform.position.y < 11.34)
        {
            //le menu de fin se lance
            SceneManager.LoadScene("EndMenu");
        }
    }
}
