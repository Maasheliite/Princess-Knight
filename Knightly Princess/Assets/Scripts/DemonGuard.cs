using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonGuard : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue unfinished;
    public DialogueTrigger dialogueTrigger;




    public void GiveMission()
    {
        dialogueTrigger.TriggerDialogue();
        QuestTraccker.DemonQuest = 1;

    }


    public void demonCheck()
    {

        if (ItemStatic.helmet)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            QuestTraccker.DemonQuest = 2;


        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(unfinished);
            FindObjectOfType<PlayerMovement>().StopFighting();
        }


    }

    public void Talk()
    {

        if (QuestTraccker.DemonQuest == 0)
        {
            GiveMission();
        }


        else if (QuestTraccker.DemonQuest == 1)
        {
            demonCheck();
        }

    }
}