using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Sword;
    public DialogueTrigger dialogueTrigger;


    public void isBerries()
    {

        if (ItemStatic.berries && !ItemStatic.hasDoneBerry)
        {
            ItemStatic.berries = false;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Sword.SetActive(true);

            ItemStatic.hasDoneBerry = true;
        }

    }

    public void GiveMission()
    {
        if (!ItemStatic.hasDoneBerry)
        {
            dialogueTrigger.TriggerDialogue();
        }
    }

    public void GetBerries()
    {
        ItemStatic.berries = true;
    }
}
