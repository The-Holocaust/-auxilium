using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterRise : MonoBehaviour {

     int n=0,i=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		n++;
          if(n%50!=0){
          	n=0;
          	i++;
        transform.position = new Vector3 (250,i/100,250);
		}
	}
}
