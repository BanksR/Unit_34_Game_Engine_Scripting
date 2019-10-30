using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCounter : MonoBehaviour
{
	public int NumberOfBullets;
	public int MaxBullets = 10;
	

	// Use this for initialization
	void Start ()
	{
		NumberOfBullets = MaxBullets;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (NumberOfBullets > 0 && Input.anyKeyDown)
		{
			NumberOfBullets--;
			Debug.Log("You Have "+NumberOfBullets + " bullets left...");
		}
		
		else if (NumberOfBullets == 0)
		{
			Debug.Log("You are out of Ammo!");
		}
		
		
	}
}
