using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour 

{

    public AudioClip playerJumpSFX;
    public AudioClip playerDeathSFX;

    private AudioSource aud;
	// Use this for initialization
	void Start () 
    {
        aud = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            aud.clip = playerJumpSFX;
            aud.Play();
        }
		
	}
}
