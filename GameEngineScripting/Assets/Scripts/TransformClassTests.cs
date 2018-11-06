using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClassTests : MonoBehaviour 
{

    Transform thisTransform;

    public float moveSpeed = 2f;

	// Use this for initialization
	void Start () 
    {
        thisTransform = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        thisTransform.Translate(v * moveSpeed, 0f, 0f);
        thisTransform.Rotate(Vector3.up, h);
		
	}
}
