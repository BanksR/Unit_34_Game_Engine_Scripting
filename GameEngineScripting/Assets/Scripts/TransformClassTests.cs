using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClassTests : MonoBehaviour 
{

    // Here we create a new variable of type Transfom
	Transform thisTransform;

	// We Create a public field for the overall speed multiplier
    public float moveSpeed = 2f;
	public float rotateSpeed = 10f;

	// Use this for initialization
	void Start () 
    {
	    // Grab a reference to the Transform Component on this game object
        thisTransform = GetComponent<Transform>();
	}
	// Update is called once per frame
	void Update () 
    {
	    // Here we store input values in some new float variables
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

	    // Using the Translate function of the Transform Class we can
	    // move the game object - 
        thisTransform.Translate(v * moveSpeed * Time.deltaTime, 0f, 0f);
        
	    // Using the Rotate function of the Tranform Class we can
	    // rotate the gameobject around a specified Vector - in 
	    // this case, Vector3.up
        thisTransform.Rotate(Vector3.up, h * rotateSpeed * Time.deltaTime);
	    
	    // Remember, in the update function, this will be evaluated
	    // every single frame - and our object will appear to 
	    // smoothly move
		
	}
}
