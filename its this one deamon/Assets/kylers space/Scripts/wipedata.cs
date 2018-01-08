using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wipedata : MonoBehaviour {
    public string [] list;
    public int startingfunds;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Wipe ()
    {
        for (int i = 0; i < list.Length; i++)
        {
           
           PlayerPrefs.SetInt(list.GetValue(i) + "", 0);
            if (list.GetValue(i)+"" == "TotalFunds")
            {
                PlayerPrefs.SetInt(list.GetValue(i) + "", startingfunds);
            }
        }
    }
}
