using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrownText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int oxygenLevel = PlayerPrefs.GetInt ("Oxygen");
		GetComponent<Text> ().text = "Oxygen Level: " + oxygenLevel;

	}
}
