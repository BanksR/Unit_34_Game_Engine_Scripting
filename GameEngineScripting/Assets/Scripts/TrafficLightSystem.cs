using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightSystem : MonoBehaviour 

{

    private Animator anims;


	// Use this for initialization
	void Start () 
    {
        anims = GetComponent<Animator>();
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Player"))
        {
            anims.SetTrigger("LightSequence");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            anims.SetTrigger("Reset");
        }
    }
}
