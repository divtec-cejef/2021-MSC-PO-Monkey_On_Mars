using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class MovePlateforme : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;
    //position de la main du leap motion
    public Transform transformLeapMotion;

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

        transformMe.position = new Vector3(transformLeapMotion.position.x * (-100), transformMe.position.y, transformMe.position.z);

        
    }
}  
