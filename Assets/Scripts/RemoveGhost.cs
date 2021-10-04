using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class RemoveGhost : MonoBehaviour
{
    public AudioClip sound;
    public ParticleSystem particleSystem;
    private bool readyForDestroy = false;

    IEnumerator particlePlay()
    {
        particleSystem.Play();

        yield return new WaitForSecondsRealtime((float)0.3);

        Destroy(gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            StartCoroutine(particlePlay());
        }
    }
}