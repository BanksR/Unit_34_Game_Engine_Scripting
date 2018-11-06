using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentHelloWorld : MonoBehaviour 
{
    Transform thisTransform;
    public float speed = 1f;


	// Use this for initialization
	void Start () 
    {
        thisTransform = GetComponent<Transform>();
	

	}

    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow))
        {
            thisTransform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            thisTransform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

    }
	
}
