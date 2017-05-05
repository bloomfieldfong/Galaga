using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour {
	
	public UiManager ui;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
	
	}
	
	// Update is called once per frame
	void Update () {


}
	void OnCollisionEnter2D(Collision2D col){

		//Al momento de colisionar una bala con el enemigo estos desapareceran y 
		//se incrementara el puntaje
		
	if(col.gameObject.name == "shots" || col.gameObject.name == "shots(Clone)"){
			ui.IncrementScore ();
		Destroy (this.gameObject);
		}
	}
}
