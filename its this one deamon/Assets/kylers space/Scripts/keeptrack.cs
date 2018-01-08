using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class keeptrack : MonoBehaviour
{
    string previous;
    public int Coal_price;
    public int Oil_price;
    public int Wind_price;
    bool sale = false;
    bool valid = false;
    // Use this for initialization
    void Start()
    {
        previous = null;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.GetComponent<Dropdown>().captionText.text + "" + PlayerPrefs.GetInt(gameObject.GetComponent<Dropdown>().captionText.text + ""));
        Debug.Log("coal" + PlayerPrefs.GetInt("Coal"));
        Debug.Log("Oil" + PlayerPrefs.GetInt("Oil"));
        Debug.Log("Wind" + PlayerPrefs.GetInt("Wind"));
    }
    public void Change()
    {

        if (previous == null)
        {
            sale = true;
            PlayerPrefs.SetInt(gameObject.GetComponent<Dropdown>().captionText.text + "", PlayerPrefs.GetInt(gameObject.GetComponent<Dropdown>().captionText.text + "") + 1);

            previous = gameObject.GetComponent<Dropdown>().captionText.text + "";

            Debug.Log(gameObject.name + "changed");

            Debug.Log(PlayerPrefs.GetInt(gameObject.GetComponent<Dropdown>().captionText.text) + "foooo");
            valid = false;
        }
        else if (!(gameObject.GetComponent<Dropdown>().captionText.text + "" == previous))
        {
            sale = true;
            PlayerPrefs.SetInt(previous + "", PlayerPrefs.GetInt(previous + "") - 1);

            PlayerPrefs.SetInt(gameObject.GetComponent<Dropdown>().captionText.text + "", PlayerPrefs.GetInt(gameObject.GetComponent<Dropdown>().captionText.text + "") + 1);

            previous = gameObject.GetComponent<Dropdown>().captionText.text;
        }
        if (gameObject.GetComponent<Dropdown>().captionText.text + "" == "None")
        {
            previous = null;
        }

        Debug.Log("rechanged");
        if (sale)
        {
            sale = false;

            if (gameObject.GetComponent<Dropdown>().captionText.text == "Oil")
            {
                if (PlayerPrefs.GetInt("TotalFunds") - Oil_price >= 0)
                {
                    Debug.Log("SOLD");
                    PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") - Oil_price);
                }
                else
                {
                    gameObject.GetComponent<Dropdown>().value = 0;
                }
            }


            if (gameObject.GetComponent<Dropdown>().captionText.text == "Wind")
            {
                if (PlayerPrefs.GetInt("TotalFunds") - Wind_price >= 0)
                {
                    Debug.Log("SOLD");
                    PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") - Wind_price);
                }

                else
                {
                    gameObject.GetComponent<Dropdown>().value = 0;
                }
            }
            
            if (gameObject.GetComponent<Dropdown>().captionText.text == "Coal")
            {
                if (PlayerPrefs.GetInt("TotalFunds") - Coal_price >= 0)
                {
                    Debug.Log("SOLD");
                    PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") - Coal_price);
                }
                else
                {
                    gameObject.GetComponent<Dropdown>().value = 0;
                }
            }
        }

    }
}
