using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMoveMenu : MonoBehaviour
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
            transform.Translate(0, (float)0.125, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            transform.Translate(0, (float)-0.125, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        if (robotVolant.transform.position.y <= premierePositionRobot - 30)
        {
            MoveTop = true;
        }
        else if (robotVolant.transform.position.y >= premierePositionRobot + 30)
        {
            MoveTop = false;
        }
    }

}
