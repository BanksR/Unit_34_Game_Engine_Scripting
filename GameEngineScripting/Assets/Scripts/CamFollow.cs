using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour 
{
    public Transform target;
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float followSpeed = 5f;

    private bool flipped = false;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        float xTarget = target.position.x + offsetX;
        float yTarget = target.position.y + offsetY;

        float newX = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float newY = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(newX, newY, -10f);



		
	}


}
