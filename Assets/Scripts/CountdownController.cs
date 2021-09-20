using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public GameObject monkey;


    private void Start()
    {
        StartCoroutine(CountdownToStart());
        
        monkey.SetActive(false);
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        timer.timerIsRunning = true;

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        
        monkey.SetActive(true);
        
        
    }
}
