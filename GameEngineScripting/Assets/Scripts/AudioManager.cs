using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    public static AudioManager Instance;

    private AudioSource aud;

	// Use this for initialization
	void Awake () 
    {
        Instance = this;
        aud = GetComponent<AudioSource>();
	}

    public void PlayMe (AudioClip PowerUpSound)
    {
        aud.clip = PowerUpSound;
        aud.Play();
    }
	
	
}
