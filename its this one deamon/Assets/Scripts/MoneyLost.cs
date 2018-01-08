using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyLost : MonoBehaviour {

	// Use this for initialization


	void Start () {

		PlayerPrefs.SetInt ("MoneyLoss", 0);		
	}
	
	// Update is called once per frame
	void Update () {

		int moneyLoss = PlayerPrefs.GetInt ("MoneyLoss");
		GetComponent<Text> ().text = "Money Lost ($): " + moneyLoss;

	}
}
