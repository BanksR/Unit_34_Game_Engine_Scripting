﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAnythingPlayerController : MonoBehaviour 
{
    private Animator anim;


	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {

        if(Input.GetKey(KeyCode.B))
        {
            anim.SetTrigger("Blunk");
        }
		
	}
}
