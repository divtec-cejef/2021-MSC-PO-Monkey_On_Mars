using UnityEngine;

public class DecorFollow : MonoBehaviour
{
    //initialisation des variables
    public GameObject monkey;
    public Vector3 postOffset;
    private Vector3 velocity;
	private float DividendeBackground;
    //position du backgroung
    public Transform transformBackgroung;
    void Update()
    {
        //si il arrive au dessus de -0.65
        if (monkey.transform.position.y >= -0.65)
        {
            DividendeBackground = monkey.transform.position.y / 6;
            //donne la même position au décor que le singe sur la position X
            transform.position = new Vector3(transform.position.x, ((monkey.transform.position.y + 23) - DividendeBackground), transform.position.z);
        }
    }
}
