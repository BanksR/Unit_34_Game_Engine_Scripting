using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour 
{

    public string noise = "";
    public string animalName = "";


    void Start()
    {
        //This is a function call
        //MakeNoise();
    }


    public void MakeNoise()
    {
        //lots of cool stuff happens here...

        Debug.Log(animalName + " says " + noise);

        //more cool game logic happens here as well...
    }

	
}
