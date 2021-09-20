using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouiMoving : MonoBehaviour
{

    public GameObject vaisseau;
    public float speed = 700;
    public bool Move;


    void Start()
    {
        int random = Random.Range(0, 10);

        Move = random == 6;
    }

    void Update()
    {
        if (Move)
        {
            transform.Translate((float)-1.2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2((float)0.6, (float)0.6);
        }
    }
}