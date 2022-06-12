using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonGuard : MonoBehaviour
{
    public Dialogue dialogue;

    public void demonCheck()
    {

        if (ItemStatic.helmet)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<PlayerMovement>().StopFighting();


        }

    }

}
