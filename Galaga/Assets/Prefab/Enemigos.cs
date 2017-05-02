using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}
	void OnCollisionEnter2D(Collision2D col){
	if(col.gameObject.name == "shots" || col.gameObject.name == "shots(Clone)"){
		Destroy (this.gameObject);
		}
	}
}
