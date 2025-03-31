using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ToSecretForest : MonoBehaviour
{
    public UnityEvent goPlace;
    public bool canBeUsed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(Time.time - ItemStatic.enterTime <= 3f)
            {
                canBeUsed = false;
            }
            if (canBeUsed)
            {
                canBeUsed = false;
                ItemStatic.enterTime = Time.time;
                goPlace.Invoke();
            }

            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canBeUsed = true;
    }

}
