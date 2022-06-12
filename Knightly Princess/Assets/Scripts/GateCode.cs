using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateCode : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ItemStatic.helmet == true)
        {
            StartCoroutine(FindObjectOfType<LevelLoader>().LoadLevel(4));
        }

        else
        {
            dialogueTrigger.TriggerDialogue();
        }
    }

}
