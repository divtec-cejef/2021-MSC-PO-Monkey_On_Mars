using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMoving : MonoBehaviour
{
    public GameObject meteorVolant;
    public GameObject monkey;
    public bool MoveTop;
    public float premierePositionRobot;

    void Update()
    {
        if (meteorVolant.transform.position.y <= monkey.transform.position.y + 25)
        {
            if (premierePositionRobot == 0)
                premierePositionRobot = meteorVolant.transform.position.y;

            transform.Translate((float)-0.1, (float)-0.1, 0);
            transform.localScale = new Vector2((float)-0.5, (float)0.5);

            if (meteorVolant.transform.position.y <= premierePositionRobot - 40)
            {
                Destroy(meteorVolant);
            }
        }
    }
    
}
