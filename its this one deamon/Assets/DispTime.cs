﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Text> ().text = System.DateTime.Now.ToLongTimeString ();
		GetComponent<Text> ().text = System.DateTime.Now.ToLongDateString ();

	}
}
