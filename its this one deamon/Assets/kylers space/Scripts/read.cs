﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class read : MonoBehaviour {
    public int number;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text>().text = PlayerPrefs.GetString("Event" + number);
    }
}
