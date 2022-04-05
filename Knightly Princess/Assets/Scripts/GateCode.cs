using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateCode : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerMovement.bigBattle == true)
        {
            SceneManager.LoadScene(4);
        }

        else
        {
            dialogueTrigger.TriggerDialogue();
        }
    }

}
