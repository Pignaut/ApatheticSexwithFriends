using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	float speed;
	public Rigidbody rb;

	void start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}










	/*
	public float speed = 6.0f, jumpspeed = 8.0f, gravity = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	
	// Update is called once per frame
	void Update () {

		moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

		moveDirection = transform.TransformDirection (moveDirection);

		moveDirection *= speed;


	}*/
}
