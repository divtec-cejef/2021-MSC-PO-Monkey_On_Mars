using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float timeStart = 120;
	public Text textBox;

	// initialise le timer à 120
	void Start()
	{
		textBox.text = timeStart.ToString();
	}

	// affiche le timer et lance l'écran de fin de jeu quand il arrive à 0
	void Update()
	{
		timeStart -= Time.deltaTime;
		textBox.GetComponent<Text>().text = Mathf.Round(timeStart).ToString();
        if(timeStart > 0.01 && timeStart < 0.2)
		{
			//charge la scene de menu de fin à la fin de timer
			SceneManager.LoadScene("EndMenu");
		}
	}
}