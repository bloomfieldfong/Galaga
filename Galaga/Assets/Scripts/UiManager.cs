using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	int score = 0;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// Imprime el puntaje que lleva el jugador 
	public void IncrementScore(){
		score = score + 10;
		scoreText.text = "Score: " + score;
	}
}
