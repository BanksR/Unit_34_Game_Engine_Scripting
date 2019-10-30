using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour 
{
    

    string[] arrayOfStringsExample = { "John", "Paul", "Ringo", "George", "George Martin" };

	// Use this for initialization
	void Start ()
	{

		//Debug.Log(arrayOfStringsExample[4]);

        foreach(string stringToTest in arrayOfStringsExample)
        {
            Debug.Log(stringToTest);
        }


	}
	
	// Update is called once per frame
	void Update () 
    {
        /*
	    if(Input.GetKeyDown(KeyCode.I))
        {
			for (int i = 0; i < 10; i++)
			{
				Debug.Log("Count is : " + i);
			}

        }
        */
	    
	    


	}
}
