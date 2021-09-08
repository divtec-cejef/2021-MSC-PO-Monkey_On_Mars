using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGhost : MonoBehaviour
{
    public GameObject ghostClonable;
    public bool cloneGhost;
    private float random;
    public Transform transformGhost;
    //clone une pièce
    private GameObject clone;


    
    void Start()
    {
        
        if(cloneGhost == false)
        {

            random = Random.Range((float)-9.20, 9);
            clone = Instantiate(ghostClonable, new Vector3(random, transformGhost.position.y, transformGhost.position.z), transform.rotation);
            cloneGhost = true;
        }

    }

}


