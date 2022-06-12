using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{
    public Dialogue dialogue;

    public void GetGhostMission()
    {

        if (ItemStatic.ring)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();


        }

    }
}
