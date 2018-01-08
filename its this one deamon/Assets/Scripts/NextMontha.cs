using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextMonth1 : MonoBehaviour {

    // Use this for initialization
    public GameObject textbox;
    public GameObject textbox2;
    public GameObject textbox3;
    public GameObject textbox4;
    public GameObject [] list ;
	public int month = 0;
	public int year = 0;
	public int eventNum = 0;
    
	void Start () {

		PlayerPrefs.SetInt ("Month", month);
		PlayerPrefs.SetInt ("Year", year);
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void OnButtonClick(){

		month++;


		if (month > 12) {

			month = 1;
			year++;

		}
		textbox.GetComponent<Text> ().text = "Month: " + month + " Year: " + year;

		eventNum = Random.Range (1, 21);
		if (eventNum <= 5) {

			textbox2.GetComponent<Text> ().text = "Nothing has happened here lately.";

		} else if (eventNum <= 10) {
			
			textbox4.GetComponent<Text> ().text = "You've earned a bonus!";
			PlayerPrefs.SetInt ("MoneyGained", PlayerPrefs.GetInt ("MoneyGained") + 25);
}
        else if (eventNum <= 15) {
			if (PlayerPrefs.GetInt ("Property") >= 1) {

				textbox3.GetComponent<Text> ().text = "A terrible storm has come through! One of your power stations could have been destroyed!";
                GameObject bad =(GameObject) list.GetValue(Random.Range(0, list.Length));
                bad.GetComponent<Dropdown>().value = 0;
				PlayerPrefs.SetInt ("Property", PlayerPrefs.GetInt ("Property") - 1);
				PlayerPrefs.SetInt ("MoneyLoss", PlayerPrefs.GetInt ("MoneyLoss") + 50);

			}


		} else if (eventNum >= 20) {

			PlayerPrefs.SetInt ("price", PlayerPrefs.GetInt ("price") + 10);

		}

	}

}
