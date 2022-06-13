using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerScript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Shears;

    public GameObject missioncheck;
    public DialogueTrigger dialogueTrigger;

    public void BucketQuest()
    {

        if (ItemStatic.HasWatered && !ItemStatic.hasDoneFarmer)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Shears.SetActive(true);

            missioncheck.SetActive(false);

            ItemStatic.hasDoneFarmer = true;
        }

    }

    public void GiveMission()
    {
        if (!ItemStatic.hasDoneFarmer)
        {
            dialogueTrigger.TriggerDialogue();
        }
    }


    private void Start()
    {
        if (ItemStatic.hasCut)
        {
            FindObjectOfType<ThornBushes>().HasShears();
        }
    }

}
