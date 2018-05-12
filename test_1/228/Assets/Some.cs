using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Some : MonoBehaviour {

	Transform t;

	// Use this for initialization
	void Start () 
	{
		t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		t.Rotate(Vector3.up * 90f * Time.deltaTime, Space.World);
	}
}
