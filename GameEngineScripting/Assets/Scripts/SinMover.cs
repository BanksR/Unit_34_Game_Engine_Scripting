using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMover : MonoBehaviour
{
	public float dist = 1f;

	
	
	// Update is called once per frame
	void Update ()
	{
		
		Debug.Log("HELLO WORLD");
		
		float x = Mathf.Sin(Time.time);
		
		Debug.Log(x);
		
		Vector3 pos = new Vector3(transform.position.x, transform.position.y * x * dist, transform.position.z);

		transform.position = pos;
	}
}
