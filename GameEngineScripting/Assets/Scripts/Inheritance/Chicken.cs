using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal 
{

	// Use this for initialization
	void Start () 
    {
        noise = "Cluckaaa";
        animalName = "Bernard the Chicken";
        MakeNoise();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
