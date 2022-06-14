using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDoor : MonoBehaviour
{
    private AudioSource TowerAudioSource;
    public AudioClip OpenDoor;
    public float Volume;

    public void Start()
    {
        TowerAudioSource = gameObject.GetComponent<AudioSource>();
    }
    public void WizzardTowerDoor()
    {
        if (ItemStatic.ring)
        {
            TowerAudioSource.PlayOneShot(OpenDoor, Volume);
            FindObjectOfType<LevelLoader>().LoadWizzard();
        }
    }
}
