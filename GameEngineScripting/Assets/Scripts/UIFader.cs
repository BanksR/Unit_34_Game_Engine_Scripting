using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class UIFader : MonoBehaviour
{

	public float fadeTime = 3f;

	public static UIFader instance; 

	private Image fadeImg;
	
	
	
	// Use this for initialization
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(this.gameObject);
		}

		fadeImg = GetComponent<Image>();
		StartCoroutine(FadeOut());
		fadeImg.color = Color.white;
	}


	public IEnumerator FadeOut()
	{
		float t = 0f;

		while (t < fadeTime)
		{
			
			fadeImg.color = Color.Lerp(Color.white, Color.clear, t / fadeTime);
			
			t += Time.deltaTime;
			
			yield return new WaitForEndOfFrame();
		}

		//StartCoroutine(FadeIn());
		yield return null;
	}

	public IEnumerator FadeIn()
	{
		Debug.Log("Starting other cooroutine");
		float t = 0f;

		while (t < fadeTime)
		{
			t += Time.deltaTime;
			fadeImg.color = Color.Lerp(Color.clear, Color.white, t / fadeTime);
			yield return new WaitForEndOfFrame();
		}

		StartCoroutine(FadeOut());
		yield return null;
	}


}
