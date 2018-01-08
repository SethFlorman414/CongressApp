using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundsDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void OnButtonClick(){

		int fundsNumber = PlayerPrefs.GetInt ("TotalFunds");
		PlayerPrefs.SetInt("TotalFunds", fundsNumber + PlayerPrefs.GetInt("MoneyGained"));
		GetComponent<Text> ().text = "Total Funds ($): " + PlayerPrefs.GetInt("TotalFunds");

	}

}
