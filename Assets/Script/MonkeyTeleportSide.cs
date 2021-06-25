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
        //test si la variable pointsJoueur et plus petit que la position du singe
        if (pointsJoueur < (int)monkey.transform.position.y + 3)
        {
            //donne les points au joueur par rapport � sa position en hauteur
            pointsJoueur = (int)monkey.transform.position.y + 3;
        }
        //si le singe va � moins que -9 dans l'axe X
        if (monkey.transform.position.x < -9)
        {
            //il se t�l�porte � droite
            monkey.transform.position = new Vector3(9, monkey.transform.position.y, 0);
        }
        //si le singe va � plus que 9 dans l'axe X
        if (monkey.transform.position.x > 9)
        {
            //il se t�l�porte � gauche
            monkey.transform.position = new Vector3(-9, monkey.transform.position.y, 0);
        }
    }
}