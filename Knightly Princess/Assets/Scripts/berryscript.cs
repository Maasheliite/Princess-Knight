using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Sword;

    public void isBerries()
    {

        if (ItemStatic.berries)
        {
            ItemStatic.berries = false;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Sword.SetActive(true);
        }

    }

    public void GetBerries()
    {
        ItemStatic.berries = true;
    }
}
