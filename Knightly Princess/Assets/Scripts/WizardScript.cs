using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue Afterthought;
    public Dialogue unfinished;

    public Dialogue happy;

    public DialogueTrigger dialogueTrigger;


    public void GetGhostMission()
    {

        if (ItemStatic.ring)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();


            QuestTraccker.WizardQuest = 2;

        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(unfinished);
            FindObjectOfType<PlayerMovement>().StopFighting();
        }
    }

    public void GiveMission()
    {
        dialogueTrigger.TriggerDialogue();
        QuestTraccker.WizardQuest = 1;

    }


    private void After()
    {
        if (ItemStatic.magicSword)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(Afterthought);
            FindObjectOfType<PlayerMovement>().StopFighting();

            QuestTraccker.WizardQuest = 3;

        }


    }


    private void Happy()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(happy);
        FindObjectOfType<PlayerMovement>().StopFighting();
    }



    public void Talk()
    {

        if (QuestTraccker.WizardQuest == 0)
        {
            GiveMission();
        }


        else if (QuestTraccker.WizardQuest == 1)
        {
            GetGhostMission();
        }

        else if (QuestTraccker.WizardQuest == 2)
        {
            After();
        }

        else
        {
            Happy();
        }
    }
}
