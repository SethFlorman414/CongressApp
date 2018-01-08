using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapSprites : MonoBehaviour {


    public Sprite[] conversation;
    public Image[] conversatio;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void ok () {
        Debug.Log(gameObject.GetComponent<Dropdown>().captionText.text);
        if (gameObject.GetComponent<Dropdown>().captionText.text == "Wind")
        {
            Debug.Log("fooooooooooo");
            gameObject.GetComponent<Image>().sprite = conversation[0];
        }
        if (gameObject.GetComponent<Dropdown>().captionText.text == "Oil")
        {
            Debug.Log("fooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            gameObject.GetComponent<Image>().sprite = conversation[1];
        }
        if (gameObject.GetComponent<Dropdown>().captionText.text == "Coal")
        {
            Debug.Log("fooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            gameObject.GetComponent<Image>().sprite = conversation[2];
        }
        
    }
}
