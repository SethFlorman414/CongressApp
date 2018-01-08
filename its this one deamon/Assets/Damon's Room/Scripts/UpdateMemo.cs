using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMemo : MonoBehaviour {
    public GameObject memo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick()
    {
        memo.GetComponent<MemoThings>().UpdateMeeeee();
    }
}
