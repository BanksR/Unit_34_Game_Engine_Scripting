using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    public static AudioManager Instance;

    private AudioSource _aud;

	// Use this for initialization
	void Awake () 
    {
        Instance = this;
        _aud = GetComponent<AudioSource>();
	}

    public void PlayMe (AudioClip PowerUpSound)
    {
        _aud.clip = PowerUpSound;
        _aud.Play();
	    
	    
    }
	
	
}
