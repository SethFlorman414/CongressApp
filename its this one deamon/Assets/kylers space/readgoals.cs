using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class readgoals : MonoBehaviour {
    public int num;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = "";

    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetString("Goal" + num);
	}
}
