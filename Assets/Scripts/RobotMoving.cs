using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMoving : MonoBehaviour
{
    public GameObject robotVolant;
    public bool MoveTop;
    public float premierePositionRobot;

    void Update()
    {
        if (premierePositionRobot == 0)
        premierePositionRobot = robotVolant.transform.position.y;
        if (MoveTop)
        {
            transform.Translate(0 ,(float)0.005,0);
            transform.localScale = new Vector2 ((float)0.5,(float)0.5);
        }
        else
        {
            transform.Translate(0 , (float)-0.005,0);
            transform.localScale = new Vector2 ((float)-0.5,(float)0.5);
        }
        if (robotVolant.transform.position.y <= premierePositionRobot - 2)
        {
            MoveTop = true;
        }
        else if (robotVolant.transform.position.y >= premierePositionRobot + 2)
        {
            MoveTop = false;
        }
    }
    
}
