using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
	public Rigidbody fireball;
	public float moveSpeed=80.0f;
	public float power=100.0f;
	public AudioClip shootSFX;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Mouse X")*Time.deltaTime * moveSpeed;
		float v = Input.GetAxis ("Mouse Y") * Time.deltaTime* moveSpeed;
		transform.Translate (h,v,0);
		if (Input.GetButtonDown ("Fire2")){
			Rigidbody instant = Instantiate (fireball, transform.position, transform.rotation) as Rigidbody;
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			instant.AddForce (fwd * power);

			if (shootSFX) {
				if (instant.GetComponent<AudioSource> ()) {

					instant.GetComponent<AudioSource> ().PlayOneShot (shootSFX);

				}// instant if
				else {
					AudioSource.PlayClipAtPoint (shootSFX, instant.transform.position);
					//play from the positiin of bullet

				}//else

			}//shootif

		}//if
	}}
