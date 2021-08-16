using UnityEngine;

public class RemoveCoin : MonoBehaviour
{
    public int PointsCoins;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
