using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject onhand;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown() //mouse clicked
    {
        rb.useGravity = false;
        rb.transform.position = onhand.transform.position;
        rb.transform.parent = GameObject.Find("FBSController").transform;
        rb.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }
    void OnMouseUpAsButton()
    {
        rb.transform.parent = null;
        rb.useGravity = true;
    }

}
