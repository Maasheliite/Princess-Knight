using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueTrigger dialogueTrigger;


    public void GetGhostMission()
    {

        if (ItemStatic.ring && !ItemStatic.hasDoneWizzard)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            ItemStatic.hasDoneWizzard = true;


        }

    }

    public void GiveMission()
    {
        if (!ItemStatic.hasDoneWizzard)
        {
            dialogueTrigger.TriggerDialogue();
        }
    }
}
