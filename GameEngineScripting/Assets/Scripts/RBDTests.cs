using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBDTests : MonoBehaviour 
{
    public float jumpForce = 1f;
    public float rayDist = 1f;
    public LayerMask layer;
    public Transform launchPos;

    private bool hasLaunched;

    Rigidbody2D rbd;

    private float jumpMulti = 0f;

	// Use this for initialization
	void Start () 
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.MovePosition(launchPos.position);
        hasLaunched = false;
	}
	
	// Update is called once per frame
	void Update () 
    {

        //This checks to see if the player is on the ground
        bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, rayDist, layer);

        //This creates the target vector using mouseposition
        Vector3 mouseTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = mouseTarget - transform.position;



        //This section of code handles the player input
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            jumpMulti += Time.deltaTime;
            Debug.Log("Jump Power = " + jumpMulti);

        }

        //Launch the ball when the space key is released
        if(Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
            rbd.AddForce(dir * jumpForce * jumpMulti);
            jumpMulti = 0f;

        }

        //Resets the player to the respawn point
        if(Input.GetKey(KeyCode.R))
        {
            rbd.velocity = Vector3.zero;
            rbd.MovePosition(launchPos.position);

        }
		
	}

    private void FixedUpdate()
    {

        //This if statement checks if the player has initially launched
        // and flicks the hasLaunched bool
        if (rbd.velocity.sqrMagnitude > 1f)
        {
            hasLaunched = true;
        }

        // This if statement check if the velocity drops below a certain threshold and resets
        // the player back to the respawn point
        if (rbd.velocity.sqrMagnitude <= 0.05f && hasLaunched)
        {
            rbd.MovePosition(launchPos.position);
            hasLaunched = false;
        }


    }
}
