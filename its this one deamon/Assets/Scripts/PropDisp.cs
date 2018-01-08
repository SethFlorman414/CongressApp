using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropDisp : MonoBehaviour {

	// Use this for initialization



	void Start () {
		PlayerPrefs.SetInt ("Property", 0);


	}
	
	// Update is called once per frame
	void Update () {


		
		int ok = PlayerPrefs.GetInt ("Coal") + PlayerPrefs.GetInt ("Wind") + PlayerPrefs.GetInt ("Oil");
		GetComponent<Text> ().text = "Properties Owned: " + ok;
		//Debug.Log (propertyNumber);
		
	}
}
