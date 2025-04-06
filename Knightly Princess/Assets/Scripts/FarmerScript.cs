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
    public GameObject bucket;

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

    public void SpawnBucket()
    {
        if (QuestTraccker.FarmerQuest == 0) bucket.SetActive(true);
    }

    private void GiveMission()
    {
        
        dialogueTrigger.TriggerDialogue();
        QuestTraccker.FarmerQuest = 1;

    }


    private void Start()
    {


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
