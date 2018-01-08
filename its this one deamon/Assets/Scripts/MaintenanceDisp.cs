using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaintenanceDisp : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("MaintenanceCost", 0);
		
	}
	
	// Update is called once per frame
	void Update () {

		int maintenanceCost = PlayerPrefs.GetInt ("MoneyLoss");
		GetComponent<Text> ().text = "Maintenance ($): " + PlayerPrefs.GetInt ("MoneyLoss");

	}


}
