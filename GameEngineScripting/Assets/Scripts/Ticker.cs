using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour {


    public float tickerMax = 10f;
    public float rate = 1f;
    private float currentTime = 0f;


    // Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {

        currentTime += Time.deltaTime;

        if(currentTime > tickerMax)
        {
            currentTime = 0f;
        }

        //Debug.Log(Mathf.Round(currentTime));
        Debug.Log(currentTime % (tickerMax / rate));
	}
}
