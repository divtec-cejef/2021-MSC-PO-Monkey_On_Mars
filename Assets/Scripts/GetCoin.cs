using UnityEngine;

public class GetCoin : MonoBehaviour
{
    static public int PointsCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si il touche la piece 
        if (collision.CompareTag("Coin"))
        {
            //incrémente de 75
            PointsCoins += 75;
        }
    }
}
