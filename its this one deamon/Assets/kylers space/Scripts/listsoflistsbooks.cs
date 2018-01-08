using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class listsoflistsbooks : MonoBehaviour {
    public string[] listk;
    public MyList[] geezzz;
    public GameObject maptarget1;
    public GameObject maptarget2;
    public GameObject maptarget3;
    public GameObject maptarget4;
    public GameObject maptarget5;
    public GameObject maptarget6;
    public GameObject maptarget7;
    public GameObject maptarget8;
    public GameObject maptarget9;
    public GameObject maptarget10;
    public GameObject maptarget11;
    public GameObject maptarget12;
    public GameObject maptarget13;
    public GameObject maptarget14;
    public GameObject maptarget15;
    public GameObject maptarget16;
    public GameObject maptarget17;
    public GameObject maptarget18;
    public GameObject maptarget19;
    public GameObject maptarget20;
    public GameObject maptarget21;
    public GameObject maptarget22;

    // Use this for initialization
    void Start () {
        int ok = 5;
        //int number = int.Parse("alright");
        // Debug.Log(number);
        Debug.Log(ok/2);
			}

	
	// Update is called once per frame
	void Update () {
		
	}
   public void okkkkk()
    {
        Calling();
    }
    void geez (int num)
    {

    }
    void Calling()
    {
        for (int i = 0; i < 5; i++)
        {
            int number = Random.Range(1, 34) - PlayerPrefs.GetInt("Pollution");
            switch (number)
            {
                case 1:
                    Hurricane(i, true);
                    break;
                case 2:
                    Typhoon(i);
                    break;
                case 3:
                    GiantHailStorm(i, true);
                    break;
                case 4:
                    Unproductivity(i);
                    break;
                case 5:
                    lightning(i);
                    break;
                case 6:
                    gale(i);
                    break;
                case 7:
                    earthquake(i);
                    break;
                case 8:
                    uselessjabber(i);
                    break;
                case 9:
                    grant(i);
                    break;
                case 10:
                    uselessjabber(i);
                    break;
                case 11:
                    uselessjabber(i);
                    break;
                case 12:
                    uselessjabber(i);
                    break;
                case 13:
                    uselessjabber(i);
                    break;
                case 14:
                    uselessjabber(i);
                    break;
                case 15:
                    uselessjabber(i);
                    break;
                case 16:
                    uselessjabber(i);
                    break;
                case 17:
                    uselessjabber(i);
                    break;
                case 18:
                    uselessjabber(i);
                    break;
                case 19:
                    uselessjabber(i);
                    break;
                case 20:
                    uselessjabber(i);
                    break;
                case 21:
                    uselessjabber(i);
                    break;
                case 22:
                    uselessjabber(i);
                    break;
                case 23:
                    uselessjabber(i);
                    break;
                case 24:
                    uselessjabber(i);
                    break;
                case 25:
                    uselessjabber(i);
                    break;
                case 26:
                    uselessjabber(i);
                    break;
                case 27:
                    uselessjabber(i);
                    break;
                case 28:
                    uselessjabber(i);
                    break;
                case 29:
                    uselessjabber(i);
                    break;
                case 30:
                    uselessjabber(i);
                    break;
                case 31:
                    grant(i);
                    break;
                case 32:
                    grant(i);
                    break;


            }
        }
    }
   // void howtocall() { }
    void Hurricane(int num, bool ok)
    {
        int number = Random.RandomRange(1, 23);
        if (ok)
        {
            PlayerPrefs.SetString("Event" + num, "A hurricane has made landfall at our location. Our building may have been damaged");
        }
        if (PlayerPrefs.GetInt("Coal") + PlayerPrefs.GetInt("Wind") + PlayerPrefs.GetInt("Oil") >= 3)
        {
            switch (number)
            {
                case 1:
                    maptarget1.GetComponent<Dropdown>().value = 0;
                    break;
                case 2:
                    maptarget2.GetComponent<Dropdown>().value = 0;
                    break;
                case 3:
                    maptarget3.GetComponent<Dropdown>().value = 0;
                    break;
                case 4:
                    maptarget4.GetComponent<Dropdown>().value = 0;
                    break;
                case 5:
                    maptarget5.GetComponent<Dropdown>().value = 0;
                    break;
                case 6:
                    maptarget6.GetComponent<Dropdown>().value = 0;
                    break;
                case 7:
                    maptarget7.GetComponent<Dropdown>().value = 0;
                    break;
                case 8:
                    maptarget8.GetComponent<Dropdown>().value = 0;
                    break;
                case 9:
                    maptarget9.GetComponent<Dropdown>().value = 0;
                    break;
                case 10:
                    maptarget10.GetComponent<Dropdown>().value = 0;
                    break;
                case 11:
                    maptarget11.GetComponent<Dropdown>().value = 0;
                    break;
                case 12:
                    maptarget12.GetComponent<Dropdown>().value = 0;
                    break;
                case 13:
                    maptarget13.GetComponent<Dropdown>().value = 0;
                    break;
                case 14:
                    maptarget14.GetComponent<Dropdown>().value = 0;

                    break;
                case 15:
                    maptarget15.GetComponent<Dropdown>().value = 0;
                    break;
                case 16:
                    maptarget16.GetComponent<Dropdown>().value = 0;
                    break;
                case 17:
                    maptarget17.GetComponent<Dropdown>().value = 0;
                    break;
                case 18:
                    maptarget18.GetComponent<Dropdown>().value = 0;
                    break;
                case 19:
                    maptarget19.GetComponent<Dropdown>().value = 0;
                    break;
                case 20:
                    maptarget20.GetComponent<Dropdown>().value = 0;
                    break;
                case 21:
                    maptarget21.GetComponent<Dropdown>().value = 0;
                    break;
                case 22:
                    maptarget22.GetComponent<Dropdown>().value = 0;
                    break;
            }
        }
    }
    void Typhoon(int num)
    {
        Debug.Log("A Typhoon has made landfall in japan");
        PlayerPrefs.SetString("Event" + num, "A typhoon has made landfall in japan");
    }
    void GiantHailStorm(int num, bool ok)
    {
        if (ok)
        {
            PlayerPrefs.SetString("Event" + num, "Major damaged incurred from a recent hail storm. We must replace some windows.");
        }
        PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") - 500);
    }
    void Unproductivity(int num)
    {
        PlayerPrefs.SetString("Event" + num, "Employees have been slacking on production. This has been dealt with.");
        PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") - (GetComponent<prices>().DoTheMath()/2));
    }
    void lightning(int num)
    {
        PlayerPrefs.SetString("Event" + num, "A major lightning storm has occurred. Plants could have been damaged.");
        int number = Random.Range(0, 25);
            if(number>= 23)
        {
            PlayerPrefs.SetString("Event" + num, "A major lightning storm has occurred. Plants have been damaged.");
            Hurricane(num, false);
        }
    }
    void grant(int num)
    {
        PlayerPrefs.SetString("Event" + num, "We have been given a goverment grant to build a new plant or we can use it for something else");
        PlayerPrefs.SetInt("TotalFunds", PlayerPrefs.GetInt("TotalFunds") + (GetComponent<prices>().DoTheMath() / 2));
    }
    void gale(int num)
    {
        PlayerPrefs.SetString("Event" + num, "Heavy winds knock rocks into your windows you must replace them");
        GiantHailStorm(num, false);
    }
    void earthquake(int num)
    {
        float nu = Mathf.Round( Random.Range(5.5f, 9.9f));
        PlayerPrefs.SetString("Event" + num,"A" + nu + " earthquake rocks the city. Our building has sustained major damage as have some of our plants");
        GiantHailStorm(num, false);
        int number = Random.Range(0, 5);
        if (number >= 2)
        {

            Hurricane(num, false);
        }
    }
    void uselessjabber(int num)
    {
        //use upper end as your case limit inclusive
        int number = Random.Range(1, 14);
        switch (number)
        {
            case 1:
                PlayerPrefs.SetString("Event" + num, "The city is expanding new oppertunities may be on the horizon.");
                break;

            case 2:
                PlayerPrefs.SetString("Event" + num, "its been a stormy night at the office, your night quite sure what this could foretell.");
                break;
            case 3:
                PlayerPrefs.SetString("Event" + num, "a hurricane has made landfall in florda");
                break;
            case 4:
                PlayerPrefs.SetString("Event" + num, "Major leak detected in alaskan pipeline");
                break;
            case 5:
                PlayerPrefs.SetString("Event" + num, "China becomes one big cloud of smog");
                break;
            case 6:
                PlayerPrefs.SetString("Event" + num, "Massive hole found in antartica");
                break;
            case 7:
                PlayerPrefs.SetString("Event" + num, "Russia invades china for resorces");
                break;
            case 8:
                PlayerPrefs.SetString("Event" + num, "Britain leaves the EU");
                break;
            case 9:
                PlayerPrefs.SetString("Event" + num, "Brasil's trandition of favelas is quickly spreading to the US");
                break;
            case 10:
                PlayerPrefs.SetString("Event" + num, "Office party time");
                break;
            case 11:
                PlayerPrefs.SetString("Event" + num, "Rival companies at peak profit");
                break;
            case 12:
                PlayerPrefs.SetString("Event" + num, "Dogs more popular than ever");
                break;
            case 13:
                PlayerPrefs.SetString("Event" + num, "Popular theory has it you can use dogs as weather detectors");
                break;
        }
    }
}
[System.Serializable]
public class MyList
{
    public string[] stringList;

    public MyList()
    {
        stringList = new string[3];
    }
}
