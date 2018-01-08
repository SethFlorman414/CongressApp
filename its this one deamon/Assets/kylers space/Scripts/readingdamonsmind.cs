using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readingdamonsmind : MonoBehaviour {
    public float timelimet;
    private float timer;
    public bool ynot = false;
    public GameObject why;
    public GameObject why2;
    public GameObject why3;
    public GameObject why4;
    // Use this for initialization
    void Start () {
        ynot = false;
        timelimet = 2.8f;
	}
	
	// Update is called once per frame
	void Update () {
        if (ynot)
        {
            timer += Time.deltaTime;
            if(timer > timelimet)
            {
                why.transform.gameObject.SetActive(true);
                why2.transform.gameObject.SetActive(true);
                why3.transform.gameObject.SetActive(true);
                why4.transform.gameObject.SetActive(true);
            }
        }
	}
    public void okokokok()
    {
        if (ynot)
        {
            ynot = false;
            timer = 0;
            why.transform.gameObject.SetActive(false);
            why2.transform.gameObject.SetActive(false);
            why3.transform.gameObject.SetActive(false);
            why4.transform.gameObject.SetActive(false);
        }
        else
        {
            ynot = true;
        }
    }
}
