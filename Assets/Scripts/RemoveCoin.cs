using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RemoveCoin : MonoBehaviour
{
    AudioSource source;
    void Start()
    {
        source = GameObject.FindObjectOfType<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            source.Play();
            Destroy(gameObject);
        }
    }
}