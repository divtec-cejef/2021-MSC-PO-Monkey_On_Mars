using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeBoxCollider : MonoBehaviour
{

    public GameObject monkey;
    private bool collider;
    

    void Update()
    {
        if (collider == false)
        {


            if (monkey.transform.position.y >= gameObject.transform.position.y + 0.5)
            {

                BoxCollider2D boxCollider2D = gameObject.AddComponent<BoxCollider2D>();
                collider = true;
            }
        }
        else if (collider == true)
        {

            if (monkey.transform.position.y <= gameObject.transform.position.y + 0.5)
            {
                GetComponent<BoxCollider2D>().enabled = false;

            } else
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
