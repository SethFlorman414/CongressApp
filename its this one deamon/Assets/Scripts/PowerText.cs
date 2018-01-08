using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		int powerNumber = PlayerPrefs.GetInt ("Power");
		GetComponent<Text> ().text = "Power: " + powerNumber;
		
	}
}
