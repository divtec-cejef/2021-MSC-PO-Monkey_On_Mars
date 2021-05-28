using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyTeleportSide : MonoBehaviour

{
    public GameObject monkey;
    public Vector3 postOffset;

    private Vector3 velocity;

    void Update()
    {
        if (monkey.transform.position.x < -9)
        {
            monkey.transform.position = new Vector3(9, monkey.transform.position.y, 0);
        }
        if (monkey.transform.position.x > 9)
        {
            monkey.transform.position = new Vector3(-9, monkey.transform.position.y, 0);
        }
    }
}