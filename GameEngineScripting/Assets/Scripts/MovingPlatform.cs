using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	public Transform _startPos;
	public Transform _endPos;

	public float _timer = 3f;

	[SerializeField] private bool _hasmoved;

	// Use this for initialization
	void Awake ()
	{
		transform.position = _startPos.position;
		//StartCoroutine(Travel());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Travel(Vector3 travelStart, Vector3 travelEnd)
	{
		float t = 0f;
		yield return new WaitForSeconds(2f);
		while (t < _timer)
		{
			transform.position = Vector3.Lerp(travelStart, travelEnd, t / _timer);
			t += Time.fixedDeltaTime;
			yield return new WaitForFixedUpdate();

		}

		_hasmoved = true;

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			StartCoroutine(Travel(transform.position, _endPos.position));
			FlashLights();

			var _otherRbd = other.GetComponent<Rigidbody2D>();
			_otherRbd.velocity = Vector2.zero;
			other.transform.parent = this.transform;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.transform.parent = null;
			StopAllCoroutines();
			StartCoroutine(Travel(transform.position, _startPos.position));
		}
	}

	void FlashLights()
	{
		TrafficLightSystem[] lights = GetComponentsInChildren<TrafficLightSystem>();
		foreach (var light in lights)
		{
			light.GetComponent<Animator>().SetTrigger("LightSequence");
		}
	}
}
