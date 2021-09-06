using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseVaisseau : MonoBehaviour
{
    static public int LosePoints;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Vaisseau"))
        {
            LosePoints += 50;
        }
    }
}
