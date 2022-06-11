using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ToSecretForest : MonoBehaviour
{
    public UnityEvent goPlace;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(ItemStatic.hasMoved == false)
            {
                ItemStatic.hasMoved = true;
                goPlace.Invoke();
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        ItemStatic.hasMoved = false;
    }
}
