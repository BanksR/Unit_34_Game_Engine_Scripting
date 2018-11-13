using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayControl : MonoBehaviour

{
	private PowerUpBlock[] _pwerUps;
	public float threshold;
	private RaycastHit2D ray;
	public LayerMask blockLayer;
	
	
	// Use this for initialization
	void Awake ()
	{
		_pwerUps = GameObject.FindObjectsOfType<PowerUpBlock>();
		//Debug.Log(_pwerUps.Length);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		foreach (var block in _pwerUps)
		{
			float dist = Vector2.Distance(transform.position, block.transform.position);
			Vector3 dir = block.transform.position - transform.position;
			ray = Physics2D.Raycast(transform.position, dir, dist, blockLayer);

			if (ray.collider != null)
			{
				if (ray.collider.CompareTag("PowerUpBlock"))
				{
					Debug.DrawRay(transform.position, dir, Color.green);
				}
				else
				{
					Debug.Log(ray.collider.name);
					Debug.DrawRay(transform.position, dir, Color.red);	
				}

				
			}
			

			
		}
	}

	
}
