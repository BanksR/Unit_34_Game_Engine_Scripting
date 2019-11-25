using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour 
{

    //public Dialog NPCPhrases;
    public Canvas dialogCanvas;
    private Dialog NPCPhrases;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    
    private Animator _anim;
    private Rigidbody2D _rbd;
    public float movespeed = 5f;

    [Space]
    [Header( "Patrol Logic")]
    public bool floorDetected = true;
    public Transform floorDetector;
    public float floorDetectRange = 2f;
    public LayerMask whatIsFloor;


    void Awake()
    {
        //dialogCanvas = GameObject.FindWithTag("Dialog").GetComponent<Canvas>();
        //NPCPhrases = dialogCanvas.GetComponentInChildren<Dialog>();

        //dialogCanvas.transform.SetParent(this.transform, false);
        //dialogCanvas.transform.localPosition += offset;

        _anim = GetComponent<Animator>();
        _rbd = GetComponent<Rigidbody2D>();


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Bump!_");
            NPCPhrases.DisplayText();
        }
    }


    void Update()
    {
        Patrol();
        
    }

    public void Patrol()
    {
        
        
        _rbd.AddForce(Vector2.left * movespeed * Time.deltaTime);
        _anim.SetFloat("Speed", _rbd.velocity.sqrMagnitude);

        floorDetected = Physics2D.Raycast(floorDetector.position, Vector2.down, floorDetectRange, whatIsFloor);
        if (!floorDetected)
        {
            Flip();
        }
    }

    public void Flip()
    {

        _rbd.velocity = Vector3.zero;
        movespeed *= -1f;
        //This function flips the character by multiplying the scale by -1
        
        Vector3 temp = new Vector3(transform.localScale.x * -1, 1f, 1f);

        transform.localScale = temp;

    }
}
