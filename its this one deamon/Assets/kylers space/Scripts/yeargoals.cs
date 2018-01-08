using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yeargoals : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("Goal2", "");
        PlayerPrefs.SetString("Goal1", "");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void year_goals()
    {
        if (PlayerPrefs.GetInt("Year") == 0)
        {
            PlayerPrefs.SetString("Goal1", "");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 1)
        {
            PlayerPrefs.SetString("Goal1", "Your goal this year is to get one plant up and running");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 2)
        {
            PlayerPrefs.SetString("Goal1", "have 3000 dollars in your balance");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 3)
        {
            PlayerPrefs.SetString("Goal1", "Own two plants");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 4)
        {
            PlayerPrefs.SetString("Goal1", "Have at least $5000 in your total balance");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 5)
        {
            PlayerPrefs.SetString("Goal1", "Own 2 plants");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 6)
        {
            PlayerPrefs.SetString("Goal1", "Manage to earn about $8000");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 7)
        {
            PlayerPrefs.SetString("Goal1", "Try to keep your pollution level below 70");
            PlayerPrefs.SetString("Goal2", "Earn $1500");
        }
        if (PlayerPrefs.GetInt("Year") == 8)
        {
            PlayerPrefs.SetString("Goal1", "Earn at least $4000");
            PlayerPrefs.SetString("Goal2", "Own 4 Plants");
        }
        if (PlayerPrefs.GetInt("Year") == 9)
        {
            PlayerPrefs.SetString("Goal1", "Have at least $12000 in your balance");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 10)
        {
            PlayerPrefs.SetString("Goal1", "Try to balance your money loss and keep it at a low level");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 11)
        {
            PlayerPrefs.SetString("Goal1", "Reach a total balance of $15000 before the end of the year");
            PlayerPrefs.SetString("Goal2", "Own one more plant");
        }
        if (PlayerPrefs.GetInt("Year") == 12)
        {
            PlayerPrefs.SetString("Goal1", "Reach a total of $10000 (In money gained) by the end of the year");
            PlayerPrefs.SetString("Goal2", "Buy three new plants");
        }
        if (PlayerPrefs.GetInt("Year") == 13)
        {
            PlayerPrefs.SetString("Goal1", "Earn a total of $2500 dollars");
            PlayerPrefs.SetString("Goal2", "Balance the number of plants you have. Pollution is an important aspect.");
        }
        if (PlayerPrefs.GetInt("Year") == 14)
        {
            PlayerPrefs.SetString("Goal1", "Watch out for what decreases your funds. Try to earn a total of $1500.");
            PlayerPrefs.SetString("Goal2", "");
            //Something needs to happen here for player to lose their money
        }
        if (PlayerPrefs.GetInt("Year") == 15)
        {
            PlayerPrefs.SetString("Goal2", "");
            PlayerPrefs.SetString("Goal1", "Get back on your feet and earn another $2500");
        }
        if (PlayerPrefs.GetInt("Year") == 16)
        {
            PlayerPrefs.SetString("Goal1", "Buy yourself one more plant");
            PlayerPrefs.SetString("Goal2", "");
        }
        if (PlayerPrefs.GetInt("Year") == 17)
        {
            PlayerPrefs.SetString("Goal2", "");
            PlayerPrefs.SetString("Goal1", "Balance your pollution level. Keep it below 40");
        }
        if (PlayerPrefs.GetInt("Year") == 18)
        {
            PlayerPrefs.SetString("Goal2", "");
            PlayerPrefs.SetString("Goal1", "Pass Year. You have no monthly goals.");
            //Couldn't think of anything
        }
        if (PlayerPrefs.GetInt("Year") == 19)
        {
            PlayerPrefs.SetString("Goal2", "");
            PlayerPrefs.SetString("Goal1", "Rebalance your funds! Earn $2500");
            //Allow something to happen for player to lose a bit of funds but just leave enough to buy a property
        }
        if (PlayerPrefs.GetInt("Year") == 20)
        {
            PlayerPrefs.SetString("Goal2", "");
            PlayerPrefs.SetString("Goal1", "Earn about $6000 before the year ends");

            if (PlayerPrefs.GetInt("Strike") < 3)
            {

                SceneManager.LoadScene("WinScene");

            }
            

        }
    }
    public void OnYearEnd()
    {
        if (PlayerPrefs.GetInt("Year") == 1)
        {
            if(!(PlayerPrefs.GetInt("Coal")+ PlayerPrefs.GetInt("Oil")+ (PlayerPrefs.GetInt("Wind")) >= 1)){
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 2)
        {
            if (!(PlayerPrefs.GetInt("TotalFunds") >= 3000))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 3)
        {
            if (!(PlayerPrefs.GetInt("Coal") + PlayerPrefs.GetInt("Oil") + (PlayerPrefs.GetInt("Wind")) >= 2))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 4)
        {
            if (!(PlayerPrefs.GetInt("TotalFunds") >= 5000))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 5)
        {
            if (!(PlayerPrefs.GetInt("Coal") + PlayerPrefs.GetInt("Oil") + (PlayerPrefs.GetInt("Wind")) >= 2))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 6)
        {
            if (!(PlayerPrefs.GetInt("TotalFunds") >= 8000))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 7)
        {
            if(!(PlayerPrefs.GetInt("Pollution") <= 70))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
            if (!(PlayerPrefs.GetInt("TotalFunds") >= 1500))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 8)
        {
            if (!(PlayerPrefs.GetInt("TotalFunds") >=4000))
            {
                PlayerPrefs.SetInt("Strike", PlayerPrefs.GetInt("Strike") + 1);
            }
        }
        if (PlayerPrefs.GetInt("Year") == 9)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 10)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 11)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 12)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 13)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 14)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 15)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 16)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 17)
        {

        }
        if (PlayerPrefs.GetInt("Year") == 18)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 19)
        {
        }
        if (PlayerPrefs.GetInt("Year") == 20)
        {

            

        }
    }
}
