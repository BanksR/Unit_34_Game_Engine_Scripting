using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class AnotherHelloWorld : MonoBehaviour

{
	private Transform _transformOnThisGameObject;

	private void Awake()
	{
		_transformOnThisGameObject = GetComponent<Transform>();
		
		Debug.Log(_transformOnThisGameObject.position);
		
	}


}
