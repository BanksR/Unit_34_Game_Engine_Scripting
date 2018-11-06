using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public AnimationCurve animCurve;

    public float amount = 2f;
    public float freq = 1f;
    public float amp = 1f;

    public float speed = 1f;

    private float timer = 0f;
    private float newX = 0f;


	// Use this for initialization
	void Start () 
    {
        
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer += Time.deltaTime;

        //if (timer > 1f)
        //timer = 0f;

        //Wave on Y
        //float newY = Mathf.Sin(Time.time * freq) * amp;
        //float newY = Mathf.PerlinNoise(0f, Time.time * freq) * amp;
        //Wave on X
        //float newX = Mathf.Cos(Time.time * freq) * amp;
        //float newX;



        //Enable both to make a cool circle

        float newY = animCurve.Evaluate(Mathf.Repeat(Time.time, speed)) * amount;

        Vector3 temp = new Vector3(transform.position.x, newY, transform.position.z);

        transform.position = temp;


	
	}
}
