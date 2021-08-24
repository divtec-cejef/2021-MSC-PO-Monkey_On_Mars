using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyTeleportSide : MonoBehaviour
{
    //initialisation des variables
    public GameObject monkey;
    public Vector3 postOffset;
    private Vector3 velocity;
    public int pointsJoueur;

    void Update()
    {
        //si le singe va à moins que -11.30 dans l'axe X
        if (monkey.transform.position.x < (float)-11.30)
        {
            //il se téléporte à droite
            monkey.transform.position = new Vector3((float)11.26, monkey.transform.position.y, 0);
        }
        //si le singe va à plus que 11.26 dans l'axe X
        if (monkey.transform.position.x > (float)11.26)
        {
            //il se téléporte à gauche
            monkey.transform.position = new Vector3((float)-11.30, monkey.transform.position.y, 0);
        }
    }
}