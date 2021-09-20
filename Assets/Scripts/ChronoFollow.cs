using UnityEngine;

public class ChronoFollow : MonoBehaviour
{
    public GameObject monkey;
    public Vector3 postOffset;

    private Vector3 velocity;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, (monkey.transform.position.y + (float)5.75), transform.position.z);
    }
}
