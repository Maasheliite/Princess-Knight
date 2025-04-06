using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue DoneMission;
    public Dialogue Afterthought;
    public Dialogue unfinished;

    public GameObject Sword;
    public DialogueTrigger dialogueTrigger;


    public void isBerries()
    {

        if (ItemStatic.berries)
        {
            ItemStatic.berries = false;
            FindObjectOfType<DialogueManager>().StartDialogue(DoneMission);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Sword.SetActive(true);
            QuestTraccker.BerryQuest = 2;

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
        QuestTraccker.BerryQuest = 1;
    }

    public void GetBerries()
    {
        ItemStatic.berries = true;
    }

    private void After()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(Afterthought);
        FindObjectOfType<PlayerMovement>().StopFighting();

    }

    public void Talk()
    {

        if (QuestTraccker.BerryQuest == 0)
        {
            GiveMission();
        }


        else if (QuestTraccker.BerryQuest == 1)
        {
            isBerries();
        }

        else
        {
            After();
        }
    }
}
