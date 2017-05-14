using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript: MonoBehaviour {

	int rand;
	public GameObject stars;

	// Use this for initialization
	void Start ()
	{
		rand = Random.Range (5, 14);

		Debug.Log ("rand: ");
		Debug.Log (rand);

		GenerateMap ();
	}

	void GenerateMap()
	{
		for(int i = 0; i < rand; i++)
		{
			float posX = Random.Range(-126, 124);
			float posY = Random.Range(-126, 124);

			stars.transform.position = new Vector3 (posX, 0.1f, posY);

			Instantiate (stars);
		}
	}
}
