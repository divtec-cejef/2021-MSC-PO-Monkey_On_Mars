using UnityEngine;


[RequireComponent(typeof(AudioSource))]
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