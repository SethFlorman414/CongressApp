using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pricing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int priceNumber = PlayerPrefs.GetInt ("price");
		GetComponent<Text> ().text = "Price for Electricity ($): " + PlayerPrefs.GetInt ("price");
		
	}
}
