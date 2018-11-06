using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour 
{
    

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {

        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("Player Moves Forward...");
        }

        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log("Player Moves Backwards");
        }


	}
}
