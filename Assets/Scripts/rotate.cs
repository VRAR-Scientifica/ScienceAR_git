using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles =  new Vector3(0, 0, 10);
        transform.Translate(Time.deltaTime * 2, 0, 0,Space.World);
	}
}
