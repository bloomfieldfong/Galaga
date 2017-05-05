﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoBala : MonoBehaviour {

	// Use this for initialization
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddForce(-1*transform.up*250);
		
	}
	
	// Update is called once per frame
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Nave") {
			Destroy (this.gameObject);
		}

		if (col.gameObject.name == "balaEnemiga(Clone)") {
			Destroy (this.gameObject);
		}

	}
}
