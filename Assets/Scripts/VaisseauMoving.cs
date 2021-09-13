using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauMoving : MonoBehaviour {

    public GameObject vaisseau;
    public float speed = 2;
    public bool MoveRight;

    void Update()
    {
        //si MoveRight est coch�
        if (MoveRight)
        {
            //le vaisseau tourne � droite
            transform.Translate((float)1.2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2 ((float)0.6,(float)0.6);
        }
        //sinon il tourne � gauche
        else
        {
            transform.Translate((float)-1.2 * Time.deltaTime * speed , 0,0);
            transform.localScale = new Vector2 ((float)-0.6,(float)0.6);
        }

        //si il va � la position -9 en x il tourne � droite
        if (vaisseau.transform.position.x <= -9)
        {
            MoveRight = true;
        }
        //si il va � la position 9 en x il tourne � gauche
        else if (vaisseau.transform.position.x >= 9)
        {
            MoveRight = false;
        }
    }
}