using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword2 : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		ItemStatic.magicSword = true;
		Destroy(this.gameObject);


		FindObjectOfType<PlayerMovement>().MagicSword();
	}


}
