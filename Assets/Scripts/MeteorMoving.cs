using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMoving : MonoBehaviour
{
    public GameObject robotVolant;
    public GameObject monkey;
    public bool MoveTop;
    public float premierePositionRobot;

    void Update()
    {
        if (robotVolant.transform.position.y <= monkey.transform.position.y + 30)
        {


            if (premierePositionRobot == 0)
                premierePositionRobot = robotVolant.transform.position.y;

            transform.Translate((float)-0.1, (float)-0.1, 0);
            transform.localScale = new Vector2((float)-0.5, (float)0.5);

            if (robotVolant.transform.position.y <= premierePositionRobot - 40)
            {
                Destroy(robotVolant);
            }
        }
    }
    
}
