using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornBushes : MonoBehaviour
{
    private AudioSource ThornAudioSource;
    public AudioClip Snipping;
    public float Volume;

    public void Start()
    {
        if (ItemStatic.hasCut)
        {
            Destroy(gameObject);
        }

        ThornAudioSource = gameObject.GetComponent<AudioSource>();
    }
    public void HasShears()
    {
        if (ItemStatic.shears)
        {
            ThornAudioSource.PlayOneShot(Snipping, Volume);
            ItemStatic.hasCut = true;
            Destroy(gameObject, 0.9f);

            ItemStatic.isInRange = false;

        }
    }
}
