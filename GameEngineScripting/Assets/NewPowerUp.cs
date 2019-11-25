using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPowerUp : MonoBehaviour {
	
	
	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.gameObject.CompareTag("Player"))
		{
			this.gameObject.SetActive(false);
			Debug.Log("You collected a power up!");
			// Play a sfx
			// Add 100 points
			// Change the UI
		}
	}
}
