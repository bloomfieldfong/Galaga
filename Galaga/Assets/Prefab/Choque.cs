using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "horizontal (1)" || col.gameObject.name == "enemigo 1" || col.gameObject.name == "enemigo 1 (clone)"){
			Destroy (this.gameObject);
			//	x.Incremento()
		}
	}
}
