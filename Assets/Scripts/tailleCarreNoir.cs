using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailleCarreNoir : MonoBehaviour
{
    public GameObject carré;
    private bool uneFois9;
    private bool uneFois99;
    private bool uneFois999;
    // Update is called once per frame
    void Update()
    {
        if (!uneFois9 && ScoreDisplay.score > 9)
        {
            carré.transform.localScale += new Vector3((float)0.7, 0, 0);
            uneFois9 = true;
        }else if (!uneFois99 && ScoreDisplay.score > 99)
        {
            carré.transform.localScale += new Vector3((float)0.7, 0, 0);
            uneFois99 = true;
        }else if (!uneFois999 && ScoreDisplay.score > 999)
        {
            carré.transform.localScale += new Vector3((float)0.7, 0, 0);
            uneFois999 = true;
        }


    }
}
