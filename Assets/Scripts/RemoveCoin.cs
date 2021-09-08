using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RemoveCoin : MonoBehaviour
{
    //AudioSource source;
    public AudioClip sound;
    void Start()
    {
        //source = GameObject.FindObjectOfType<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //source.Play();
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy(gameObject);
        }
    }
}