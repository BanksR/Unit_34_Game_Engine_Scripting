using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour 
{


    
	// The OnTriggerEnter2D is called by the physics engine
    
    public void OnTriggerEnter2D (Collider2D other)
    {
        // Here we test the thing we bumped into - does it have the tag "Player?"
        
        if (other.gameObject.CompareTag("Player"))
        {
            // If we have bumped into the player, we can do a bunch of stuff
            
            // Do a bunch of other stuff...
            
            //Play Pick up sound
            //Subtract 1 from coin count
            //Play particle system
            
           
            // turn off the visibilty of the gameobject that this script is attached to
           gameObject.SetActive(false);
        }

    }
}
