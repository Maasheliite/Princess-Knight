using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerScript : MonoBehaviour
{
    public Dialogue DoneMission;
    public Dialogue Afterthought;
    public Dialogue unfinished;
    public GameObject Shears;

    public DialogueTrigger dialogueTrigger;

    private void BucketQuest()
    {

        if (ItemStatic.HasWatered)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(DoneMission);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Shears.SetActive(true);

            QuestTraccker.FarmerQuest = 2;

        }

        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(unfinished);
            FindObjectOfType<PlayerMovement>().StopFighting();
        }


    }

    private void GiveMission()
    {
        
        dialogueTrigger.TriggerDialogue();
        QuestTraccker.FarmerQuest = 1;

    }


    private void Start()
    {
        if (ItemStatic.hasCut)
        {
            FindObjectOfType<ThornBushes>().HasShears();
        }
    }


    private void After()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(Afterthought);
        FindObjectOfType<PlayerMovement>().StopFighting();


    }



    public void Talk()
    {

        if (QuestTraccker.FarmerQuest == 0)
        {
            GiveMission();
        }


        else if (QuestTraccker.FarmerQuest == 1)
        {
            BucketQuest();
        }

        else
        {
            After();
        }
    }
}
