using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingScript : MonoBehaviour 
{
    public Light myLight;
    public Color startCol;
    public Color endCol;
    public float fadeTime = 3f;

    private float timer = 0f;


	// Use this for initialization
	void Start () 
    {
        myLight.color = new Color(1, 0, 0);

        myLight.intensity = 1f;
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer += Time.deltaTime;

        if (timer > fadeTime)
        {
            timer = 0f;
        }




        myLight.color = Color.Lerp(startCol, endCol, timer / fadeTime);

		
	}
}
