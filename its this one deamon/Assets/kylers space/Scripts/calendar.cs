using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calendar : MonoBehaviour {
    public int pollutionlimit;
    
    // Use this for initialization
    void Start() {
        PlayerPrefs.SetInt("Pollution", 0);
        GameObject.Find("Cal1").gameObject.GetComponent<SpriteRenderer>().enabled = true;

    }

    // Update is called once per frame
    void Update() {
        Debug.Log(PlayerPrefs.GetInt("Month")+"month");    }
    public void calendershift()
    {
        //if(!((PlayerPrefs.GetInt("Pollution") > pollutionlimit))) {




        if (!(PlayerPrefs.GetInt("Month") == 13))
        {
            GameObject.Find("Cal" + PlayerPrefs.GetInt("Month")).gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GameObject.Find("Cal1").gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        Debug.Log("come after done");
        if (!(PlayerPrefs.GetInt("Month") == 1))
        {
            GameObject.Find("Cal" + (PlayerPrefs.GetInt("Month") - 1) + "").gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if ( PlayerPrefs.GetInt("Month") == 1)
            {
                GameObject.Find("Cal12").gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

       // }
    }
}
