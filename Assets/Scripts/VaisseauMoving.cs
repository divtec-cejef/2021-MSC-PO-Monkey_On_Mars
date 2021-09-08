using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class VaisseauMoving : MonoBehaviour {

 

    public GameObject vaisseau;
    public float speed = 2;
    public bool MoveRight;

 

    void Update()
    {
        if (MoveRight)
        {
            transform.Translate((float)1.2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2 ((float)0.6,(float)0.6);
        }
        else
        {
            transform.Translate((float)-1.2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2 ((float)-0.6,(float)0.6);
        }
        if (vaisseau.transform.position.x <= -9)
        {
            MoveRight = true;
        }
        else if (vaisseau.transform.position.x >= 9)
        {
            MoveRight = false;
        }
    }
}