using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New2DController : MonoBehaviour 
{

    //Player character parameters
    public float playerSpeed = 1f;
    public float jumpForce = 10f;

    //LayerMasks detect collisions with either floors or walls
    public LayerMask isFloor;
    public LayerMask isWall;

    //How far to cast the ray when detecting collisions
    public float rayLen = 1f;
    public float wallRayLen = 1f;

    //Setting our private variables and component references
    private Rigidbody2D rbd;
    private Animator anims;
    [SerializeField]
    bool isGrounded;
    [SerializeField]
    bool canWallJump;
    public bool flipped;
    private float hMovement;

	// Use this for initialization
	void Start () 
    {
        flipped = false;
        rbd = GetComponent<Rigidbody2D>();
        anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

	    
        //Player input is stored as a float either -1, 0, or 1
        hMovement = Input.GetAxisRaw("Horizontal");

        //This makes sure, every frame, the correct animation is played
        //The walk animation is triggered by the player input
        Animate(hMovement);


        //This checks the input to see which way the character should face and calls the
        //Flip() funtion if necassary
        if (hMovement == -1 && !flipped)
        {
            Flip();
        }

        else if (hMovement == 1 && flipped)
        {
            Flip();
        }

        //This line applies the forces to the RigidBody2D to move the player
	    CastRays();
        rbd.AddForce(new Vector3 (hMovement * playerSpeed * Time.deltaTime, 0f, 0f));
		
	}

    private void Update()
    {

        //Checking Collisions
        RaycastHit2D groundCheck = Physics2D.Raycast(transform.position, Vector3.down, rayLen, isFloor);
        //Debug.Log(isGrounded);

        if (groundCheck.collider != null)
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
        }


        //Character jump - checks to see if the player is on the floor or wall
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            anims.SetTrigger("Jump");
            rbd.AddForce(new Vector2(0f, jumpForce));
        }

        else if (Input.GetKeyDown((KeyCode.Space)) && canWallJump && !isGrounded)
        {
            
            rbd.AddForce(new Vector2(hMovement * -1f * jumpForce, jumpForce * 5f));
        }
    }

    void Flip()
    {
        //This function flips the character by multiplying the scale by -1
        flipped = !flipped;
        Vector3 temp = new Vector3(transform.localScale.x * -1, 2f, 2f);
        wallRayLen *= -1;
        transform.localScale = temp;
    }

    void Animate(float hVal)
    {

        //This uses the absolute value (only positive values) of the player input
        //When no input is detected default to the idle animation
        if(hVal != 0)
        {
            //anims.SetBool("WallGrip", false);
            anims.SetFloat("Speed", Mathf.Abs(hVal));
        }

        else
        {
            anims.SetFloat("Speed", 0f);
        }
        
    }

    void CastRays()
    {
        RaycastHit2D sideRay = Physics2D.Raycast(transform.position, Vector2.left * wallRayLen, Mathf.Abs(wallRayLen), isWall);
        Debug.DrawRay(transform.position, Vector2.left * wallRayLen);

        if (sideRay.collider != null && !isGrounded)
        {
            Debug.Log(sideRay.collider.name);
            anims.SetBool("WallGrip", true);
            canWallJump = true;
            rbd.drag = 50f;
        }
        else
        {
            anims.SetBool("WallGrip", false);
            canWallJump = false;
            rbd.drag = 1f;
        }
    }
}
