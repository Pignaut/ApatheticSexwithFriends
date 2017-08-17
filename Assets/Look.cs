using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour {

	float sensitivityX = 1.5f;
	float sensitivityY = 1.5f;

	Quaternion originalRotation;

	float rotationX = 0f;
	float rotationY = 0f;

	void Start()
	{
		originalRotation = transform.parent.localRotation;
	}

	void Update()
	{
		rotationX += Input.GetAxis ("Mouse X") * sensitivityX;
		rotationX += Input.GetAxis ("Mouse Y") * sensitivityY;

		Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
		Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);

		transform.parent.localRotation = originalRotation * xQuaternion * yQuaternion;
	}
		
}
