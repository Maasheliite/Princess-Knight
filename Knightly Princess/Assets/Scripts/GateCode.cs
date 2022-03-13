using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateCode : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerMovement.bigBattle == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else
        {
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
    }

}
