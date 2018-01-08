using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class switchsprite : MonoBehaviour {
    public Sprite use;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void button()
    {
        gameObject.transform.GetComponent<Image>().sprite = use;
    }
}
