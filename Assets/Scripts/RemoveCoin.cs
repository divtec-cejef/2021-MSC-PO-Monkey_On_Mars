using UnityEngine;

public class RemoveCoin : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}