using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class strikes : MonoBehaviour {
    public int strike_marker;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Strike") >= strike_marker)
        {
            gameObject.GetComponent<Image>().enabled = true;
        }
        if(PlayerPrefs.GetInt("Strike") >= 3)
        {
            SceneManager.LoadScene("EndScene");
        }
	}

}
