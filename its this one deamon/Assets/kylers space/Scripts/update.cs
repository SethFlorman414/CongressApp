using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class update : MonoBehaviour {
    public string item;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat(item) + "";
	}
}
