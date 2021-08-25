using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoin : MonoBehaviour
{
    public GameObject coinClonable;
    public bool cloneCoin;
    private float random;
    public Transform transformCoin;
    //clone une pièce
    private GameObject clone;


    // Start is called before the first frame update
    void Start()
    {
        
        if(cloneCoin == false)
        {

            random = Random.Range((float)-5.71, (float)5.62);
            clone = Instantiate(coinClonable, new Vector3(random, 30, transformCoin.position.z), transform.rotation);
            cloneCoin = true;
        }

    }

}


