using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvenClick : MonoBehaviour {

	// Use this for initialization

	public GameObject Canvas;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.X)) {
			gameObject.GetComponent<Canvas>().enabled = !gameObject.GetComponent<Canvas>().enabled;

		}
		
	}
}
