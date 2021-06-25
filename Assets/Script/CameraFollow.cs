using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //initialisation des variables
    public GameObject monkey;
    public Vector3 postOffset;
    private Vector3 velocity;

    void Update()
    {
        //donne la même position à la camera que le singe sur la position X
        transform.position = new Vector3(transform.position.x, (monkey.transform.position.y + 2), transform.position.z);
    }
}
