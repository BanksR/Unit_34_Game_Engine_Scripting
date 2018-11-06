using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increment : MonoBehaviour 
{

    public int valueToAdd = 1;

    private int currentVal = 0;

	// Use this for initialization
	void Start () 
    {
        currentVal = 0;

	}
	
	// Update is called once per frame
	void Update () 
    {

        if(Input.GetKey(KeyCode.I))
        {
            currentVal += valueToAdd;
            Debug.Log("My Score is: " + currentVal);
        }

	}
}
