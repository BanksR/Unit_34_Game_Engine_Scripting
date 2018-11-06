using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

{


    public float speed = 10f;
    public float jumpForce = 100f;
    public LayerMask groundLayer;

    // SOUND FX
    public AudioClip playerJump;
    public AudioClip playerDeath;

    //private bool isGrounded = true;
    public float maxSpeed = 20f;

    private bool facingRight = true;

    private Rigidbody2D rbd;
    private Animator anims;

    //Ray ray;

	// Use this for initialization
	void Start () 
    {
        rbd = GetComponent<Rigidbody2D>();
        anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log(IsGrounded());

        if(Input.GetKey(KeyCode.Space) && IsGrounded() || Input.GetKey(KeyCode.Space) && TouchingWall())
        {
            Jump();
            //anims.SetTrigger("Jump");
        }


		
	}

    private void FixedUpdate()
    {
        float vel = Input.GetAxis("Horizontal");

        if(vel < 0 && facingRight)
        {
            FlipMode();
        }

        if (vel > 0 && !facingRight)
        {
            FlipMode();
        }



        anims.SetFloat("Speed", Mathf.Abs(vel));
        TouchingWall();

        anims.SetFloat("yVel", rbd.velocity.y);




		if(GameManager.Instance.canControl)
            Move(vel);
    }



    private void Move(float moveVel)
    {

        if(Mathf.Abs(rbd.velocity.x) < maxSpeed)
        {
            Vector2 velo = new Vector2(moveVel * speed, rbd.velocity.y);
            rbd.velocity = velo;
        }

        else
        {
            Vector2 clampedVel = new Vector2(maxSpeed * moveVel, rbd.velocity.y);
            rbd.velocity = clampedVel;
        }

    }

    private void FlipMode()
    {
        facingRight = !facingRight;
        Vector3 flipScale = new Vector2(transform.localScale.x * -1, 2);
        transform.localScale = flipScale;
        
    }

    private void Jump()
    {

        if(GameManager.Instance.canControl)
        {
			rbd.velocity = new Vector2(rbd.velocity.x, 0f);
			rbd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //Play mump anim
            anims.SetTrigger("Jump");
			//AudioManager.Instance.JumpNoise(playerJump);

        }

    }


    private bool IsGrounded()
    {
        //Debug.DrawRay(transform.position, Vector2.down, Color.red, 0f);
        //This function returns true if the raycast collides with the ground layer...
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.5f, groundLayer.value))
        {
            anims.SetBool("isGrounded", true);
            return true;
        }

        else
        {
            anims.SetBool("isGrounded", false);
            return false;
        }
    }

    private bool TouchingWall()
    {


        Debug.DrawRay(transform.position, rbd.velocity.normalized, Color.green, 0f);

        //this function returns true if the player is colliding with a wall
        if(Physics2D.Raycast(transform.position, Vector2.right, 0.4f, groundLayer.value) ||Physics2D.Raycast(transform.position, Vector2.left, 0.4f, groundLayer.value))
        {
            anims.SetBool("WallGrip", true);
            rbd.gravityScale = 1f;
            return true;
        }

        else
        {
            anims.SetBool("WallGrip", false);
            rbd.gravityScale = 3f;
            return false;

        }
    }
}
