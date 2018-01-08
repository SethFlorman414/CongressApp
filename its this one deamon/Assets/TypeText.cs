using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeText : MonoBehaviour {

	// Use this for initialization
	string textValue;
	float totalTime = 0;
	int charCount = 0;
	public float textSpeed = 0.1f;
	void Start () {
		//making the assumption we are attaching this script to the text object
		textValue = gameObject.GetComponent<Text> ().text;
	}
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;
		if (totalTime >= textSpeed && textValue.Length > charCount) {
			charCount++;
			totalTime = 0;

		}

		string displayText = textValue.Substring (0, charCount);
		gameObject.GetComponent<Text> ().text = displayText;

	}
}
