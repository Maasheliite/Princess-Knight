using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ToSecretForest : MonoBehaviour
{
    public UnityEvent goPlace;
    private bool isInRange;

    void Update()
    {
        if (isInRange && ItemStatic.hasMoved == false)
        {
            goPlace.Invoke();
            ItemStatic.hasMoved = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ItemStatic.hasMoved = false;
            isInRange = false;
        }
    }
}
