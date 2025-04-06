using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingPickup : MonoBehaviour
{
    public AudioClip PickUp;
    private AudioSource ItemAudioSource;
    void Start()
    {
       if (ItemStatic.ring) Destroy(this.gameObject);
       ItemAudioSource = this.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ItemAudioSource.PlayOneShot(PickUp);
            ItemStatic.ring = true;
            Destroy(this.gameObject, 0.7f);
        }
       
    }

}
