using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class MovePlateforme : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;
    public GameObject monkey;
    float posPlateforme;


    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    public float groundCheckRadius;
    public LayerMask collisionLayers;

    public static bool test;

    //position de la main du leap motion
    public Transform transformPalm;

    //position de la plateforme avec la main du leap motion
    public Transform transformMe;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
        

    }

    void Update()
    {


        //initialise le "isGrounded" pour savoir quand est-ce que le personne touche le sol
        test = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, collisionLayers) || Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, collisionLayers);
        Debug.Log(test);



        //pour que la plateforme suive le singe avec un espace de 5
        //transformMe.position = new Vector3(transformPalm.position.x * (-100), monkey.transform.position.y - 2, transformMe.position.z);

        posPlateforme = monkey.transform.position.y;

        //print(posPlateforme);
        if(monkey.transform.position.y + 2 < transformMe.transform.position.y)
        {
            transformMe.position = new Vector3(transformPalm.position.x * (-100), monkey.transform.position.y - 5, transformMe.position.z);
        }
        else
        {
            if (monkey.transform.position.y <= (transformMe.position.y + 5))
            {
                //la plateforme ne doit pas descendre
                transformMe.position = new Vector3(transformPalm.position.x * (-100), transformMe.position.y, transformMe.position.z);
            }
            else
            {
                transformMe.position = new Vector3(transformPalm.position.x * (-100), monkey.transform.position.y - 5, transformMe.position.z);
            }
        }

        

        
        //Nous faisons des calculs pour positionner la plateforme correctement devant l'?cran
        //transformMe.position = new Vector3(transformPalm.position.x * (-100), transformPalm.position.y * 40 + 65, transformMe.position.z);
        
    }
}  
