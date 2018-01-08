using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizedChaos : MonoBehaviour {
    Animator anime;
    public int personNumber;
    private float timer;
    private float timez;
	// Use this for initialization
	void Start () {
        anime = GetComponent<Animator>();
        timer = Random.Range(1.0f, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
        timez += Time.deltaTime;
        if (timez >= timer && anime.GetBool("isWalking") == false)
        {
            anime.SetBool("isWalking", true);
        }
        //0 = Briefcase, 1 = Coffee, 2 = Moneybags, 3 = Papers, 4 = Tablet
        if (personNumber == 0)
        {
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("BriefcaseWalking"))
            {
                Debug.Log("Hello");
                anime.SetBool("isWalking", false);
                timer = Random.Range(1.0f, 4.0f);
                timez = 0;
            }
        } else if (personNumber == 1)
        {
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("CoffeeSipping"))
            {
                Debug.Log("Bello");
                anime.SetBool("isWalking", false);
                timer = Random.Range(1.0f, 4.0f);
                timez = 0;
            }
        } else if (personNumber == 2)
        {
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("MoneybagsTwirl"))
            {
                Debug.Log("Cello");
                anime.SetBool("isWalking", false);
                timer = Random.Range(1.0f, 4.0f);
                timez = 0;
            }
        } else if (personNumber == 3)
        {
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("PapersWalking"))
            {
                Debug.Log("Jello");
                anime.SetBool("isWalking", false);
                timer = Random.Range(1.0f, 4.0f);
                timez = 0;
            }
        } else if (personNumber == 4)
        {
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("TabletTyping"))
            {
                Debug.Log("Bello");
                anime.SetBool("isWalking", false);
                timer = Random.Range(1.0f, 4.0f);
                timez = 0;
            }
        }
    }


}
