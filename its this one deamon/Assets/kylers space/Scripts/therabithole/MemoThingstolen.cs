using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoThingstolen : MonoBehaviour {
    Animator anime;
    int stage = 0;
    float timer = 0;
    public float limit = 0;
    public Sprite idling;
    public GameObject[] list;
    // Use this for initialization
    void Start () {
        anime = GetComponent<Animator>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (stage == 1 || stage == 3)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer >= limit && stage == 1)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    
                }
                stage = 2;
                //gameObject.GetComponent<SpriteRenderer>().sprite = idling;
                anime.SetInteger("Stage", stage);
                timer = 0;
            } else if (timer >= limit && stage == 3)
            {
                stage = 0;
                anime.SetInteger("Stage", stage);
                timer = 0;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    public void UpdateMeeeee()
    {
        if (stage == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            stage++;
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

        } else if (stage == 2)
        {
            stage++;
            gameObject.transform.rotation = new Quaternion(180,0,0,0);
        }   
        anime.SetInteger("Stage", stage);
        Debug.Log(anime.GetInteger("Stage"));
    }
}
