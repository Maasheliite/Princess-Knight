using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject BerryPrize;
    public GameObject Berries;

    private bool hasBerries;
    public void isBerries()
    {
        hasBerries = PlayerMovement.berries;

        if (hasBerries)
        {
            PlayerMovement.berries = false;
            BerryPrize.SetActive(true);
            Berries.SetActive(false);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

        }

    }
}
