using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyGained : MonoBehaviour {

	// Use this for initialization

	public int moneyGained = 0;

	void Start () {

		PlayerPrefs.SetInt ("MoneyGained", 0);
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
