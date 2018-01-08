using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travel : MonoBehaviour {
    public GameObject intro;
    public GameObject menu;
    /* private int place = 0;
     public GameObject[] places;
     private GameObject goTowards;

     public float moveSpeed = 5;
     private float startTime;
     private float journeyLength;

     public Transform startingPlace;
     public Transform endingPlace;*/

    public float timeLimit;
    private float timer;
    // Use this for initialization
    void Start () {
        /* goTowards = places[place];
         Debug.Log(place);
         Debug.Log(goTowards);


         GameObject starting = places[0];
         GameObject ending = places[places.Length - 1];
         startingPlace = starting.transform.position;
         startTime = Time.time;
         journeyLength =Vector3.Lerp()*/
        GetComponent<Rigidbody2D>().velocity = new Vector3(220, 220, 0);
        GetComponent<Rigidbody2D>().angularVelocity = -700.0f;

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= timeLimit)
        {
            menu.SetActive(true);
            intro.SetActive(false);
        }
        //transform.position = goTowards.transform.position;
        
	}

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Travel")
        {
            Debug.Log("Hit Something");
            place++;
            //goTowards = places[place];
        }
    }*/
}
