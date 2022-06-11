using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingPickup : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        ItemStatic.ring = true;
    }

}
