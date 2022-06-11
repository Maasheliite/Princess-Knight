using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetScript : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		ItemStatic.helmet = true;
		Destroy(this.gameObject);
	}
}
