using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour 
{
    public AnimationCurve animCurve;
    public float shakeTime = 3f;
    public float shakeMulti = 1f;

    private float timer;
    private bool shakerMaker;
	

    // Use this for initialization
	void Start () 
    {
        timer = 0f;
        shakerMaker = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
       float t = Timer();

        if(Input.GetKeyDown(KeyCode.S))
        {
            //ParticleManager.Instance.Rubble();
            timer = 0f;
            shakerMaker = true;
        }


        float noiseCurve = animCurve.Evaluate(t / shakeTime);

        Vector2 temp = new Vector2(Mathf.PerlinNoise(Time.time * shakeMulti, 0f) - 0.5f, Mathf.PerlinNoise(0f, Time.time * 123124f * shakeMulti) - 0.5f) * noiseCurve;

        if(shakerMaker)
        {
            transform.position = new Vector3(transform.position.x * temp.x, transform.position.y * temp.y, -10f); 
        }

	}

    float Timer()
    {
        
        timer += Time.deltaTime;

        if(timer > shakeTime)
        {
            shakerMaker = false;
            timer = 0f; 
        }


        return timer;

    }
}
