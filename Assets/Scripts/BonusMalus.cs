using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusMalus : MonoBehaviour
{
    static public string  logsPoints;
    public Text logText;
    public Text plusText;

    public float timeRemaining = 1;
    public bool timerIsRunning = false;
    public bool test = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        plusText.text = "";
        if (collision.CompareTag("Vaisseau"))
        {
            logsPoints = "-50";
            logText.color = Color.red;
            timeRemaining = 1;
            timerIsRunning = true;
        }
        else if (collision.CompareTag("Ghost"))
        {
            logsPoints = "-50";
            logText.color = Color.red;
            timeRemaining = 1;
            timerIsRunning = true;
        }
        else if (collision.CompareTag("Coin"))
        {
            logsPoints = "+75";
            logText.color = Color.green;
            plusText.text = "+";
            timeRemaining = 1;
            timerIsRunning = true;
        }
    }
    void Update()
    {
        logText.text = logsPoints;

        
        

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                
            }
            else
            {
                logsPoints = "";
                timeRemaining = 0;
                timerIsRunning = false;
                plusText.text = "";
            }
        }
    }

}
