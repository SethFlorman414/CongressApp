using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pollution : MonoBehaviour {

    // Use this for initialization

    public int pollution = 0;
    public float scaler;
	void Start () {

        PlayerPrefs.SetInt("Pollution", pollution);
		
	}
	
	// Update is called once per frame
	public void Pollutionnextmounth () {


        if (PlayerPrefs.GetInt("Oil") >= 1 || PlayerPrefs.GetInt("Coal") >= 1) 
        {
            pollution += Mathf.RoundToInt(PlayerPrefs.GetInt("Oil") * scaler) +Mathf.RoundToInt(PlayerPrefs.GetInt("Coal") * scaler);
            pollution -= Mathf.RoundToInt(PlayerPrefs.GetInt("Scrubber"));
            if(pollution < 0)
            {
                pollution = 0;
            }
            PlayerPrefs.SetInt("Pollution", pollution);
        }

        if(pollution >= 100)
        {
            SceneManager.LoadScene("EndScene");
        }

		
	}
}
