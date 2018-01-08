using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyProperty : MonoBehaviour {

	// Use this for initialization

	public int property = 0;
	public int totalFunds = 0;

	void Start () {

		PlayerPrefs.SetInt ("Property", property);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//PlayerPrefs.GetInt ("TotalFunds");


	}

	public void OnButtonClick(){

		if (PlayerPrefs.GetInt ("TotalFunds") >= 50) {
			PlayerPrefs.SetInt ("TotalFunds", PlayerPrefs.GetInt ("TotalFunds") - 1000);
			PlayerPrefs.SetInt ("Property", PlayerPrefs.GetInt ("Property") + 1);
			//Debug.Log (PlayerPrefs.GetInt ("TotalFunds"));
	
		}



	}

}
