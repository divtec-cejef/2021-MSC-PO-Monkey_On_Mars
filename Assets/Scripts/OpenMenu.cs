using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MenuMain");
        }
    }
}