using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreatePLateforme : MonoBehaviour
{

    public GameObject plateformeClonable;
    public Transform monkey;
    public bool clonePlateforme;
    private float random;
    private int posY = -1;
    private int nombrePlateforme;

    //clone une plateforme
    private GameObject clone;



    void Update()
    {

        if (nombrePlateforme<= 30)
        {

            random = Random.Range((float)-9.20, 9);
            clone =  Instantiate(plateformeClonable, new Vector3(random, posY, monkey.position.z), transform.rotation);
            posY += 5;
            nombrePlateforme++;

                
        }

    }
}
