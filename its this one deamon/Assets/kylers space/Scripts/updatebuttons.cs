using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class updatebuttons : MonoBehaviour {
	
    public Text profit;
    public Text maintenance;
    public Text funds;
    public Text politicalpower;
    public Text powerproduced;
    public Text price;
    public Text pollution;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        profit.GetComponent<Text>().text = "profit:"+ GetComponent<prices>().DoTheMath() + "";
        maintenance.GetComponent<Text>().text = "Money Lost:" + PlayerPrefs.GetInt("MoneyLost") + "";
        funds.GetComponent<Text>().text = "Total Funds ($): " + PlayerPrefs.GetInt("TotalFunds") + "";
        politicalpower.GetComponent<Text>().text = "People: " + (300 * (PlayerPrefs.GetInt("Coal")) + (30 * PlayerPrefs.GetInt("Wind")) + (370 * PlayerPrefs.GetInt("Oil"))) + "";
        powerproduced.GetComponent<Text>().text = "Power Produced: " + (4400 * (PlayerPrefs.GetInt("Coal")) + (3300 * PlayerPrefs.GetInt("Wind")) + (5000 * PlayerPrefs.GetInt("Oil"))) + "";
        price.GetComponent<Text>().text = PlayerPrefs.GetInt("price") + "Price for Electricity ($) ";
        pollution.GetComponent<Text>().text = "Pollution:" + PlayerPrefs.GetInt("Pollution") + "";
    }
   public void Onclick()
    {
        profit.GetComponent<Text>().text = PlayerPrefs.GetInt("profit") + "";
		maintenance.GetComponent<Text>().text = "Money Lost:" + PlayerPrefs.GetInt("MoneyLost") + "";
		funds.GetComponent<Text>().text = "Total Funds ($): " + PlayerPrefs.GetInt("TotalFunds") + "";
        politicalpower.GetComponent<Text>().text = "People: " + (300*(PlayerPrefs.GetInt("Coal") ) + (300*PlayerPrefs.GetInt("Wind") ) + (300*PlayerPrefs.GetInt("Oil"))) + "";
        powerproduced.GetComponent<Text>().text = "Power Produced: " + (4400 * (PlayerPrefs.GetInt("Coal")) + (3300 * PlayerPrefs.GetInt("Wind")) + (5000 * PlayerPrefs.GetInt("Oil"))) + "";
        price.GetComponent<Text>().text = PlayerPrefs.GetInt("price") + "";
        pollution.GetComponent<Text>().text ="Pollution:"+ PlayerPrefs.GetInt("Pollution") + "";
    }
}
