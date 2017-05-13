using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript: MonoBehaviour {

	int width, height;
	int rand;

	public GameObject plane;
	public GameObject stars;

	Bounds bounds;
	public MeshRenderer rend;



	// Use this for initialization
	void Start ()
	{
		plane = GameObject.Find ("plane");

		rend = plane.GetComponent<MeshRenderer>();

		rand = Random.Range (0, 9);

		GenerateMap ();
	}

	// Update is called once per frame
	void Update ()
	{
		
	}


	void GenerateMap()
	{
		//int i = 0;
			
		//while(i < rand)
		for(int i = 0; i < rand; i++)
		{
			Vector2 X = new Vector2 (rend.bounds.min.x, rend.bounds.max.x);
			Vector2 Y = new Vector2(rend.bounds.min.y, rend.bounds.max.y);

			float xAxisMin = X.x;
			float xAxisMax = X.y;
			float yAxisMin = X.x;
			float yAxisMax = X.y;

			float r1 = Random.Range(xAxisMin, xAxisMax);
			float r2 = Random.Range(yAxisMin, yAxisMax);

			Instantiate (stars);

			i++;
		}
	}
}
