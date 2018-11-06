using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal 
{
    
	// Use this for initialization
	void Start () 
    {
        noise = "Meow";
        animalName = "Iris the Cat";

        MakeNoise();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
