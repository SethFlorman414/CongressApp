using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drown : MonoBehaviour {

	// Use this for initialization

	public GameObject Water;
	public int Oxygen = 0;
	public float drownTime = 0;

	void Start () {

		PlayerPrefs.SetInt ("Oxygen", Oxygen);

	}
	
	// Update is called once per frame
	void Update () {



	}


	void OnTriggerStay(Collider collision){


		if (collision.gameObject.tag == "Water") {
			drownTime += Time.deltaTime;
			if (drownTime >= 6) {
				PlayerPrefs.SetInt ("Oxygen", PlayerPrefs.GetInt ("Oxygen") - 1);
				drownTime = 0;
			}


		}

	}

}
