using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//alpha1 is the 1 key on top of the keyboard
		if (Input.GetKey (KeyCode.Alpha1)) {
			//load Level1
			SceneManager.LoadScene("Level1");
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			//load Level1
			SceneManager.LoadScene("Movement");
		}
	}
	public void LevelSwitch1 () {
		SceneManager.LoadScene("Level1");
	}
}
