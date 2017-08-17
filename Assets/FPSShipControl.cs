using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSShipControl : MonoBehaviour {

	float accel = .05f;
	float rev = .025f;
	float topSpeed = 15f;
	float topRevSpeed = -10f;

	public float currentSpeed = 0;

	public GameObject projectile;

	public float fireRate = 0.1f;
	private float nextfire = 0.0f;


	// Use this for initialization
	void Start () {
		Cursor.visible = false;	//hides the cursor
		Cursor.lockState = CursorLockMode.Locked; //locks cursor movement
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey ("w"))
		{
			float newSpeed = currentSpeed + accel;
			currentSpeed = newSpeed;

			if (currentSpeed > topSpeed)
				currentSpeed = topSpeed;
		}

		if (Input.GetKey ("s"))
		{
			float newSpeed = currentSpeed - rev;
			currentSpeed = newSpeed;

			if (currentSpeed < topRevSpeed)
				currentSpeed = topRevSpeed;
		}

		if (Input.GetKey ("a"))
			transform.Rotate ((Vector3.down * Time.deltaTime) * 50);

		if (Input.GetKey ("d"))
			transform.Rotate ((Vector3.up * Time.deltaTime) * 50);

		if (Input.GetKey ("e"))
			transform.Rotate ((Vector3.back * Time.deltaTime) * 50);

		if (Input.GetKey ("q"))
			transform.Rotate ((Vector3.forward * Time.deltaTime) * 50);

		if (currentSpeed > 0)
			transform.Translate (Vector3.forward * Time.deltaTime * currentSpeed);

		if (currentSpeed < 0)
			transform.Translate (Vector3.back * Time.deltaTime * currentSpeed);

		if (Input.GetMouseButtonDown (0))
		{
			shoot ();
		}
	}

	private void shoot()
	{
		if (Time.time > nextfire)
		{
			nextfire = Time.time + fireRate;

			GameObject bullet;
			GameObject muz = GameObject.Find ("Barrel");
			GameObject pro = projectile;
			Rigidbody rb;

			bullet = Instantiate (pro, muz.transform.position, Quaternion.identity);
			rb = bullet.GetComponent<Rigidbody> ();
			rb.AddForce (muz.transform.up * -5000);

			Destroy (bullet, 5);
		}
	}
}
