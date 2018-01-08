using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducePower : MonoBehaviour {

	// Use this for initialization

	public int power = 0;
	public int property = 0;

	void Start () {

		PlayerPrefs.SetInt ("Power", power);
		PlayerPrefs.SetInt ("Property", property);

		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void OnButtonClick(){
		property = PlayerPrefs.GetInt ("Property");
		if (property >= 1) {
			PlayerPrefs.SetInt ("Power", PlayerPrefs.GetInt ("Power") + 1);
			power = PlayerPrefs.GetInt ("Power");

		}

	}

}
