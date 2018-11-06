using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal 
{

	void Start () 
    {
        noise = "Bork, Bork";
        animalName = "Richard the Dog";


        MakeNoise();
	}
		
}
