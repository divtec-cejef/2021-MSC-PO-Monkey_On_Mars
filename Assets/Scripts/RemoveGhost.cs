using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RemoveGhost : MonoBehaviour
{
    AudioSource source2;
    void Start()
    {
        source2 = GameObject.FindObjectOfType<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            source2.Play();
            Destroy(gameObject);
        }
    }
}