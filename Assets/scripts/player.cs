﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public string toPrintClass = "Hello world as class variable";
	public float speed =5;

	// Use this for initialization
	void Start () {
		string toPrint = "Hello World as a variable";
		Debug.Log (toPrintClass);
		string returned1 = TestFunction ("TestFunction Variable message", 1);
		string returned2 = TestFunction ("TestFunction Variable message", 2);
		Debug.Log ("returned1 = " + returned1);
			Debug.Log("returned2 = " + returned2);


	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D> ();
		ourRigidBody.velocity = Vector2.right * speed;
	}

	string TestFunction(string message, int count) {
		Debug.Log (message + " " + count);

		return "Returned String";
	}
}
