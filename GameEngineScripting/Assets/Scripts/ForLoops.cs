﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
          
	}
	
	// Update is called once per frame
	void Update ()
	{
		for (int i = 0; i < 5; i++)
		{
			Debug.Log("Value is: " + i);
		}
		
	}
}
