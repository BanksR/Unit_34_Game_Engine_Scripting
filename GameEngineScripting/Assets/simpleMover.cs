using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMover : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log("You have selected the Knife!");
		}

	}
}
