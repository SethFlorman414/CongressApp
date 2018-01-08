using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework : MonoBehaviour {
    public int adhdnum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       Debug.Log( adhd(adhdnum));
        Debug.Log(aDD(adhdnum) + "geez");
        Debug.Log(fib(adhdnum,0,1,0)+ "oh fib");
        MyFib(4);
    }
    int adhd(int num)
    {
        if (num <= 0)
        {
            return num;
        }
        return (num + adhd(num - 1));
    }
    int aDD(int num)
    {
        if (num <= 1)
        {
            return num;
        }
        return (num * aDD(num - 1));
    }


    //fib sequence adds two previous #s to get the current index. 0 = 0, 1 = 1 to start.


    int MyFib(int num)
    {
        if(num <= 1)
        {
            return num ;
        }
        return MyFib(num - 1) +  MyFib(num - 2) ;

    }




























    int fib(int num,int O,int one,int zero)
    {
        if (zero < num)
        {
            return fib(num, one, O + one, zero + 1);
        }
        else
        {
            return (O);
        }
    }


    

}
