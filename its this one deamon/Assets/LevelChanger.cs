using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1)) {
			//load level 1
			SceneManager.LoadScene("Level1");
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			//load level 2
			SceneManager.LoadScene("Movement");
		}
	}
}
