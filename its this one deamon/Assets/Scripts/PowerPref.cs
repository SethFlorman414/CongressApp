using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPref : MonoBehaviour {

	public int power = 0;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("Power", power);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
