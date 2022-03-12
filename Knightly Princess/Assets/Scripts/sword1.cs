using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword1 : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
		FindObjectOfType<ItemManager>().SwordPickup();
		Destroy(this.gameObject);
	}
}
