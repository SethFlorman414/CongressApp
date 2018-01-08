using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MemoThings : MonoBehaviour {
    Animator anime;
    int stage = 0;
    float timer = 0;
    public float limit = 4;
    public float limit2 = 5.4f;
    public GameObject buttonnnnn;
    private bool loading = false;
    //public Sprite idling;
	// Use this for initialization
	void Start () {
        anime = GetComponent<Animator>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (stage == 1 || stage == 3 || loading)
        {
            timer += Time.deltaTime;
            loading = true;
            buttonnnnn.GetComponent<Button>().enabled = false;
            //Debug.Log(timer);
            if (timer >= limit && stage == 1)
            {
                
                stage = 2;
                //gameObject.GetComponent<SpriteRenderer>().sprite = idling;
                anime.SetInteger("Stage", stage);
                
            } else if (timer >= limit2 && stage == 3)
            {
                
                stage = 0;
                anime.SetInteger("Stage", stage);
                
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
               
            }
            if (timer >= limit2 + 0.2f || timer >= limit2 + 0.2f)
            {
                loading = false;
                timer = 0;
                buttonnnnn.GetComponent<Button>().enabled = true;
            }
        }
       /* if (loading)
        {
            timer += Time.deltaTime;
            if (timer >= limit2 + 0.2f || timer >= limit2 + 0.2f)
            {
                loading = false;
                timer = 0;
                buttonnnnn.GetComponent<Button>().enabled = true;
            }*/
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
            //buttonnnnn.GetComponent<Button>().enabled = true;
            stage++;
            gameObject.transform.rotation = new Quaternion(180,0,0,0);
        }   
        anime.SetInteger("Stage", stage);
        Debug.Log(anime.GetInteger("Stage"));
    }
}
