using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauMoveMenu : MonoBehaviour
{

    public GameObject vaisseau;
    public float speed = 50;
    public bool MoveRight;

    void Update()
    {
        //si MoveRight est coch�
        if (MoveRight)
        {
            //le vaisseau tourne � droite
            transform.Translate((float)1.2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2((float)1.25, (float)1.25);
        }
        //sinon il tourne � gauche
        else
        {
            transform.Translate((float)-1.2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2((float)-1.25, (float)1.25);
        }

        //si il va � la position -9 en x il tourne � droite
        if (vaisseau.transform.position.x <= -140)
        {
            MoveRight = true;
        }
        //si il va � la position 9 en x il tourne � gauche
        else if (vaisseau.transform.position.x <= -40)
        {
            MoveRight = false;
        }
    }
}