using UnityEngine;

public class GetCoin : MonoBehaviour
{
    static public int PointsCoins;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            PointsCoins += 25;
        }
    }
}
