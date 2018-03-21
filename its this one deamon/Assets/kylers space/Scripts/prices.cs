using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prices : MonoBehaviour {
	
    public int oil, wind, coal, price, hydro;

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("price", price);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onclick()
    {
        PlayerPrefs.SetInt("powerproduced", (PlayerPrefs.GetInt("Coal") * coal) + (PlayerPrefs.GetInt("Wind") * wind) + (PlayerPrefs.GetInt("Oil") * oil));

		PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") + (PlayerPrefs.GetInt("Coal") * coal) * PlayerPrefs.GetInt("price"));

		PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") + (PlayerPrefs.GetInt("Wind") * wind) * PlayerPrefs.GetInt("price"));

		PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") + (PlayerPrefs.GetInt("Oil") * oil) * PlayerPrefs.GetInt("price"));

        PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") + (PlayerPrefs.GetInt("Hydro") * hydro) * PlayerPrefs.GetInt("price"));

        PlayerPrefs.SetInt("MoneyLost", (PlayerPrefs.GetInt("Oil") * oil * 80) + (PlayerPrefs.GetInt("Wind") * wind * 30)
                + (PlayerPrefs.GetInt("Coal") * coal * 70));

        PlayerPrefs.SetInt("MoneyGained",PlayerPrefs.GetInt("MoneyLost")+ (PlayerPrefs.GetInt("Oil") * oil) + (PlayerPrefs.GetInt("Wind") * wind)
                + (PlayerPrefs.GetInt("Coal") * coal) * PlayerPrefs.GetInt("price"));
        
    }
    public int DoTheMath()
    {
        return (((PlayerPrefs.GetInt("Coal") * coal) * PlayerPrefs.GetInt("price")) + ((PlayerPrefs.GetInt("Oil") * oil) * PlayerPrefs.GetInt("price"))+ (PlayerPrefs.GetInt("Hydro") * hydro) + ((PlayerPrefs.GetInt("Wind") * wind * price)) );
    }
}
