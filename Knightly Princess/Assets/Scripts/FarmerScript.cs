using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerScript : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Shears;

    public GameObject missioncheck;

    public void BucketQuest()
    {

        if (ItemStatic.HasWatered)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();

            Shears.SetActive(true);

            missioncheck.SetActive(false);
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
