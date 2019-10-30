using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour 
{

    public string myName;
    public int myAge;
    public float myHeightInMetres;
    public bool myBoolVariable = true;


    void Start()
    {
        //Here we call into usage the PrintMessage() Function in our Hello world Class 
        PrintMessages();

    }



    //Here we have created our very own Function - a new 'Machine' in our HelloWorld 'Factory'
    //Take note of the syntax of how to create a new function - we'll be making lots of them!
    void PrintMessages()
    {

        //This function (or Machine to use our Factory analogy)

        if (myName.Length > 2)
		{
			Debug.Log("Hello " + myName);
		}
		else
		{
			Debug.LogError("Please enter a valid name"); // logs a Unity Error to the console
            
            return; //The return keyword is a command to exit the function at this point
		}

		if (myAge > 15 && myAge < 100)
		{
			Debug.Log("You are: " + myAge + "years old");
		}
		else
		{
			Debug.LogError("Please enter a valid age range 15-100");
       
            return;
		}


		if (myHeightInMetres > 1.0f && myHeightInMetres < 3.0f)
		{
			Debug.Log("Your height in metres is: " + myHeightInMetres);
		}
		else
		{
			Debug.LogError("Please enter a valid height");
            
            return;
		}


    }
}
