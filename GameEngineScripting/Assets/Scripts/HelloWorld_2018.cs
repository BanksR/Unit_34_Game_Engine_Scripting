using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld_2018 : MonoBehaviour 
{
    public string myName = "Richard";
    public int myAge = 40;

    public float myHeight = 1.81f;

    public bool areYouMale = true;


	// Use this for initialization
	void Start () 
    {
        Debug.Log("Hello " + myName);

        Debug.Log("Dank Souls 2D Alpha 0.1");

        if (areYouMale == true)
        {
            Debug.Log("You are a Male...");
        }
        else
        {
            Debug.Log("You are Female...");
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
