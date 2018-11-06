using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour 
{


    
	public virtual void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //Play Pick up sound
            //Subtract 1 from coin count
            //Play particle system
            

           gameObject.SetActive(false);
        }

    }
}
