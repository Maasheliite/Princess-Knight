using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSoundSystem : MonoBehaviour
{
    public SoundEffects moveSound;
    public SoundEffects idleSound;
    public SoundEffects attackSound;
    public SoundEffects deathSound;

    public bool randomPitch;
    public float pitchMin;
    public float pitchMax;

    private AudioSource audioSource;

    public void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void ChangePitch()
    {
        if (randomPitch)
        {
            audioSource.pitch = Random.Range(pitchMin, pitchMax);
        }
    }

    private void playSound(SoundEffects effect)
    {
        if (randomPitch)
        {
            ChangePitch();
        }
        audioSource.PlayOneShot(effect.audioclip, effect.soundVolume);
    }

    public void playMoveSound()
    {
        playSound(moveSound);
    }
    public void playIdleSound()
    {
        playSound(idleSound);
    }
    public void playAttackSound()
    {
        playSound(attackSound);
    }
    public void playDeathSound()
    {
        playSound(deathSound);
    }
}
