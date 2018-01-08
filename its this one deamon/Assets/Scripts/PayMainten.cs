using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayMainten : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonClick(){

		int cost = PlayerPrefs.GetInt ("MaintenanceCost");

		if(PlayerPrefs.GetInt("TotalFunds") >= 50){
			
		PlayerPrefs.SetInt ("MaintenanceCost", PlayerPrefs.GetInt ("MaintenanceCost") - 50);
		}


	}

}
