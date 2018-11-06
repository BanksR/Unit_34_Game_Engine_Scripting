using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

    public int unlockID = 0;
    public ParticleSystem parts;
    public ParticleSystem dustMotes;

    private PlayerInventory inv;
    private Animator anims;

	// Use this for initialization
	void Awake () 
    {
        inv = GameObject.FindWithTag("Player").GetComponent<PlayerInventory>();
        anims = GetComponent<Animator>();
	}
	
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //check the players inv to see if a key matches the unlockID - if yes, trigger the anim

            foreach(Key id in inv.keyInventory)
            {
                if(id.keyID == unlockID)
                {
                    //play door open SFX / VFX
                    anims.SetTrigger("WallUp");
                    parts.Play();
                    dustMotes.Play();
                    inv.RemoveKey(id);
                    return;
                }
            }
        }
    }
}
