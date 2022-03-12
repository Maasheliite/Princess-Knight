using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berryscript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject BerryPrize;

    private bool hasBerries;
    public void isBerries()
    {
        hasBerries = PlayerMovement.berries;
        Debug.Log("Ha");

        if (hasBerries)
        {
            Debug.Log("Ha");
            PlayerMovement.berries = false;
            BerryPrize.SetActive(true);
            dialogue.sentences[0] = "Thank you for berries! Have this sword";
        }

    }
}
