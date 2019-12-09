using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	// This Vector 2 establishes an initial offset for the camera
	public Vector2 initOffset;
	// This is a public reference to the object we want to follow
	public GameObject ObjectToFollow;
	
	[Space]
	// This is how quickly the camera will update its position
	public float speed;


	// Update is called once per frame
	void Update ()
	{
		// Here we calculate a new float based on our speed per second
		float interpolation = speed * Time.deltaTime;

		// Here we create a new Vector 3 to store our modifed position data, using
		// a linear interpolation (LERP - a blend) between the camera's current
		// position and the position of the object to follow. The blend speed
		// is the interpolation value.
		Vector3 newPosition = this.transform.position;
			
		// Here we are modifying the individual components of our new Vector 3 using
		// the Lerp function of the Mathf Class.
		newPosition.x = Mathf.Lerp(this.transform.position.x, ObjectToFollow.transform.position.x + initOffset.x, interpolation);
		newPosition.y = Mathf.Lerp(this.transform.position.y, ObjectToFollow.transform.position.y + initOffset.y, interpolation);

		// Once we have the modified values, we can assign our Vector 3 data
		// to the camera's position.
		transform.position = newPosition;

		
	}
}
