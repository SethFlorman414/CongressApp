using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour {

	// Use this for initialization



	void Start () {


        MyFib(9);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int Peanut(int num)
    {

        if(num <= 0)
        {

            return num;

        }

        return num + Peanut(num - 1);

    }


    public int Butter(int num)
    {


        if(num <= 0)
        {

            return num;

        }

        return num * Butter(num - 1);


    }


   int MyFib(int fibNum)
    {


        if(fibNum <= 1)
        {

            return fibNum;

        }

        return (fibNum - 1) + (fibNum - 2);


    }


}
