using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyGainDisp : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("MoneyGained", 0);

	}
	
	// Update is called once per frame
	void Update () {

		int moneyNumber = PlayerPrefs.GetInt ("MoneyGained");
		GetComponent<Text> ().text = "Money Gained ($): " + moneyNumber;
		
	}
}
