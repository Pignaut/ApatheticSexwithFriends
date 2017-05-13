using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public int prefab;
	public int rand;
	public GameObject[] stars = new GameObject[3];
	public GameObject[] planets;

	// Use this for initialization
	void Start ()
	{
		prefab = Random.Range(0, 2);
		rand = Random.Range (0, 9);

		planets = new GameObject[rand];

		Instantiate (stars[prefab]);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
