using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeBoxCollider : MonoBehaviour
{
    public GameObject monkey;
    private bool collider;
    public Material noFriction;

    void Update()
    {
        if (collider == false)
        {
            if (monkey.transform.position.y >= gameObject.transform.position.y + (float)0.65)
            {

                GetComponent<BoxCollider2D>().enabled = true;

                collider = true;
            }
        }
        else if (collider == true)
        {

            if (monkey.transform.position.y <= gameObject.transform.position.y + 0.2)
            {
                GetComponent<BoxCollider2D>().enabled = false;

            } else
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
