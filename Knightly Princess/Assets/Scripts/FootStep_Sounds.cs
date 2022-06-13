using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep_Sounds : MonoBehaviour
{ 
    public float stepDelay=0.24f;
    private AudioSource audioSource;
    private Animator anim;
    public AudioClip currentClip;
    private bool couroutineOn;
    public float StepVolume= 1;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource> ();
        anim = this.gameObject.GetComponent<Animator>();
        couroutineOn = true;
        
        StartCoroutine(Walking());
    }

    IEnumerator Walking()
    {
        while (couroutineOn == true)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Movement"))
            {
                audioSource.PlayOneShot(currentClip,StepVolume);
            }
            else
            {
                //audioSource.Stop();
            }
            yield return new WaitForSeconds(stepDelay);
        }
    }
}