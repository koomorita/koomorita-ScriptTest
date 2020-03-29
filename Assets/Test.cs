using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = { 10, 20, 30, 40, 50, };
        for(int i = 0; i<=4; i++)
        {
            Debug.Log(points[i]);
        }


        int[] points2 = { 10, 20, 30, 40, 50, };
        for(int i = 4; i >=0; i--)
        {
            Debug.Log(points2[i]);

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
