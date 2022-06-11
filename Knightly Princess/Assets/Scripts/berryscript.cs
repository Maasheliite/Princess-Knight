using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Sword;
    public GameObject Berries;

    private bool hasBerries;
    public void isBerries()
    {
        hasBerries = ItemStatic.berries;

        if (hasBerries)
        {
            Sword.SetActive(true);
            ItemStatic.berries = false;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();


        }

    }

    public void GetBerries()
    {
        ItemStatic.berries = true;
    }
}
