using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject monkey;
    public Vector3 postOffset;

    private Vector3 velocity;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, (monkey.transform.position.y + 1), transform.position.z);
    }
}
