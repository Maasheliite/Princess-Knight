using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword2 : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		FindObjectOfType<ItemManager>().Sworduppers();
		Destroy(this.gameObject);
	}
}
