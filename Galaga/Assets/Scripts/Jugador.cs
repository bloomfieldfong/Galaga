﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
	Vector2 jugador;
	float   factorVel;
	public GameObject shots;
	Vector3 velocidad = new Vector3(0.0f, 10.0f);
	// Use this for initialization
	void Start () {
		jugador = new Vector2(0.0f,0.0f);
		factorVel = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		jugador.x = 0.0f;

		//mueve al jugador de derecha a izquierda
		if (Input.GetKey (KeyCode.LeftArrow)) {
			jugador.x = -factorVel * Time.deltaTime;
			transform.Translate (jugador);
		}
		if (Input.GetKey(KeyCode.RightArrow) ){
			jugador.x = factorVel * Time.deltaTime;
			transform.Translate(jugador);	
		} 
		//dispara las balas que tirara el jugador 
		if (Input.GetKeyUp (KeyCode.Space)) {
			Vector2 posIni = GameObject.Find("Nave").transform.position;
			Instantiate (shots, posIni, Quaternion.identity);
			GameObject.Find("shots(Clone)").GetComponent<Rigidbody2D>().velocity = velocidad;
			GameObject.Find("shots(Clone)").name = "shots";


		}
	}

}
