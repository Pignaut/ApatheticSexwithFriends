using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;

public class starSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown()
	{
		string temp;
		Text txt;
		string txt1;


		txt = this.GetComponent<Text> ();
		temp = txt.text;

		txt1 = this.gameObject.name;

		Debug.Log("txt = " + temp);
		Debug.Log("temp = " + txt1);
	}

}
