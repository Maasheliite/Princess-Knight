using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEnterCave : MonoBehaviour
{
    private bool isInRange;

    void Update()
    {
        if (isInRange)
        {

            if (ItemStatic.sword == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    FindObjectOfType<LevelLoader>().LoadCave();
                }

            }

        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;

            if(ItemStatic.sword == false)
            {
                FindObjectOfType<DialogueTrigger>().TriggerDialogue();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
