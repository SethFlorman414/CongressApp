using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebtDisp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		PlayerPrefs.SetInt ("Debt", 0);

	}
	
	// Update is called once per frame
	void Update () {

		int debtCost = PlayerPrefs.GetInt ("Debt");
		GetComponent<Text> ().text = "Debt ($): " + PlayerPrefs.GetInt ("MoneyLoss");
		
	}
}
