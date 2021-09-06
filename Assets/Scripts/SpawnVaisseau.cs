using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVaisseau : MonoBehaviour
{

    public GameObject vaisseauClonable;
    public bool cloneVaisseau;
    private float random;
    public Transform transformVaisseau;
    //clone un vaisseau
    private GameObject clone;
    public float timeRemaining = 3;
    public bool timerIsRunning = false;


    void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;

        if (cloneVaisseau == false)
        {

            random = Random.Range((float)-9.20, 9);
            clone = Instantiate(vaisseauClonable, new Vector3(random, transformVaisseau.position.y, transformVaisseau.position.z), transform.rotation);
            cloneVaisseau = true;
        }

    }

    void Update()
    {
        cloneVaisseau = false;
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Destroy(clone);
                if (cloneVaisseau == false)
                {

                    random = Random.Range((float)-9.20, 9);
                    clone = Instantiate(vaisseauClonable, new Vector3(random, transformVaisseau.position.y, transformVaisseau.position.z), transform.rotation);
                    cloneVaisseau = true;
                }

                timeRemaining = 3;
                //Mettre false pour arreter la boucle au bout d'une fois
                timerIsRunning = true;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

       
    }
}
