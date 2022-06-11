using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBucket : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
	{
		ItemStatic.emptyBucket = true;
		Destroy(this.gameObject);
	}
}
