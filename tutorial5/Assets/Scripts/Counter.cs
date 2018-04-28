using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
	public Text text;
	public int counter;
	public Rigidbody fireball;


	// Use this for initialization
	void Start () {
		counter = 0;
		text.text = "count: " + counter.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider other)
	{ 
		if (other.CompareTag ("twig")) {

			counter++;
			text.text = "count: " + counter.ToString ();


		}


	}
}
