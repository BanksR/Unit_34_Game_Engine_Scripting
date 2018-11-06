using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 1f;
    public float jumpForce = 10f;

    Rigidbody2D rbd;

	// Use this for initialization
	void Start () 
    {
        rbd = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        float hMovement = Input.GetAxisRaw("Horizontal");

        rbd.AddForce(new Vector3(hMovement * Time.deltaTime * speed, 0.0f, 0.0f));
		
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rbd.AddForce(new Vector3(rbd.velocity.x, jumpForce, 0.0f));
        }
    }


}
