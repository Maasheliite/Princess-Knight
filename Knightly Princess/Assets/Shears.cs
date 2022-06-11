using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shears : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		ItemStatic.shears = true;
		Destroy(this.gameObject);
	}
}
