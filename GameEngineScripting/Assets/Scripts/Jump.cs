using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

	private Rigidbody2D _rbd;

	public float jumpForce = 10f;
	public Transform LaunchPos;

	public float collisionRadius = 1f;
	public LayerMask groundLayer;
	
	
	//Point and click jump...
	private Vector3 _mousePosToWorldPos;
	private Vector2 _launchVector;
	
	
	void Awake ()
	{
		// Grab a reference to the RigidBody component
		_rbd = GetComponent<Rigidbody2D>();
		//Initialise the ball object by running the ResetBall() function
		ResetBall();
	}
	
	// FixedUpdate is locked to the physics engine time interval and can not vary like Update()
	void FixedUpdate ()
	{
		//bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, collisionRadius, groundLayer);
		bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, collisionRadius, groundLayer);
		
		
		if (Input.GetMouseButtonDown(0) && isGrounded)
		{
			
			//Here we grab the screen position of a mouse click and convert it to world space
			_mousePosToWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			
			//We then calculate the launch vector by subtracting mouse pos from the balls current position
			_launchVector = _mousePosToWorldPos - transform.position;
			
			//We then plug our newly calculated launch Vector into our AddForce function...
			_rbd.AddForce(_launchVector.normalized * jumpForce);
		}


		//Here we check to see if the user presses R - then we run the reset ball function
		if (Input.GetKey(KeyCode.R))
		{
			ResetBall();
		}



	}

	//This helper function draws out our collision radius
	private void OnDrawGizmos()
	{
		//Gizmos.DrawWireSphere(transform.position, collisionRadius);
		//Gizmos.DrawRay(transform.position, Vector2.down * collisionRadius);
		//Gizmos.DrawLine(transform.position, Vector3.down * collisionRadius);
	}

	//This function resets the ball back to launchPos.position
	private void ResetBall()
	{
		
		//reset any spin / rotation the object has
		_rbd.angularVelocity = 0f;
		//reset the velocity of the gameobject
		_rbd.velocity = Vector2.zero;
		//Magically move the position of the ball - bypassing the physics engine
		_rbd.MovePosition(LaunchPos.position);
	}
}
