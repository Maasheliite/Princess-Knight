using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonEnter : MonoBehaviour
{
    private bool isInRange;

    void Update()
    {
        if (isInRange)
        {

            if (ItemStatic.magicSword == true)
            {
                ItemStatic.isInRange = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    FindObjectOfType<LevelLoader>().LoadDungeon();
                }

            }

        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;

            if (ItemStatic.magicSword == false)
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
            ItemStatic.isInRange = false;
        }
    }
}
