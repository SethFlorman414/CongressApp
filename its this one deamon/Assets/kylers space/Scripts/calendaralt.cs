using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class calendaralt : MonoBehaviour {
    public int pollutionlimit;
    
    // Use this for initialization
    void Start() {
        PlayerPrefs.SetInt("Pollution", 0);
        GameObject.Find("Cal1").gameObject.GetComponent<Image>().enabled = true;

    }

    // Update is called once per frame
    void Update() {
        Debug.Log(PlayerPrefs.GetInt("Month")+"month");    }
    public void calendershift()
    {
        //if(!((PlayerPrefs.GetInt("Pollution") > pollutionlimit))) {

        if (!(PlayerPrefs.GetInt("Month") == 13))
        {
            GameObject.Find("Cal" + PlayerPrefs.GetInt("Month")).gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("Cal1").gameObject.GetComponent<Image>().enabled = true;
        }
        Debug.Log("come after done");
        if (!(PlayerPrefs.GetInt("Month") == 1))
        {
            GameObject.Find("Cal" + (PlayerPrefs.GetInt("Month") - 1) + "").gameObject.GetComponent<Image>().enabled = false;
        }
        if ( PlayerPrefs.GetInt("Month") == 1)
            {
                GameObject.Find("Cal12").gameObject.GetComponent<Image>().enabled = false;
        }

       // }
    }
}