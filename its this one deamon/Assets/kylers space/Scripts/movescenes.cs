using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movescenes : MonoBehaviour {
    public string ok;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void click()
    {
        SceneManager.LoadScene(ok);
    }
    public void StartThisGame()
    {
        SceneManager.LoadScene("Intro");
    }
}
