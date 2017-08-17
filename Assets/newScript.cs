using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;

public class newScript: MonoBehaviour {

	int rand;
	int prefab;
	int Name;
	const int names = 30;

	Text txt;

	string[] temp = new string[names];

	public GameObject[] stars = new GameObject[3];

	StreamReader sr;

	// Use this for initialization
	void Start ()
	{
		rand = Random.Range (14, 30);

		Debug.Log ("rand: ");
		Debug.Log (rand);

		sr = new StreamReader ("Assets/Resources/systemNames.txt");

		for (int i = 0; i < names; i++)
		{
			temp [i] = sr.ReadLine ();
		}


		GenerateMap ();
	}

	void GenerateMap()
	{
		for(int i = 0; i < rand; i++)
		{
			prefab = Random.Range(0, 3);	//chooses from a number of prefabs
			Name = Random.Range (0, 29);	//chooses from a number of names

			float posX = Random.Range(-126, 124);	//random x position on the plane
			float posY = Random.Range(-126, 124);	//random y position on the plane

			stars[prefab].transform.position = new Vector3 (posX, 0.1f, posY);	//sets the position

			txt = stars [prefab].GetComponent<Text> ();		//gets the Text component of the current prefab
			txt.text = temp [Name];							//sets the Text component to be the star's name

			Instantiate (stars[prefab]);	//Instantiates the prefab
		}
	}
}
