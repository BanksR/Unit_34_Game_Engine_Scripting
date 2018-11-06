using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour 
{
    public float jumpForce = 10f;
    public LayerMask layer;
    Rigidbody2D rbd;
    private bool isGrounded;

	// Use this for initialization
	void Start () 
    {
        rbd = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void FixedUpdate () 

    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = mousePos - transform.position;

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.75f, layer);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rbd.AddForce(dir * jumpForce);
        }
	}
}
