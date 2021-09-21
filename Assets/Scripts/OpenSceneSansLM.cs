using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenSceneSansLM : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game - Copie");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
