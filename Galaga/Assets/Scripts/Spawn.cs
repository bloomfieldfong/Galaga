using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject[] enemigos;
	public Vector3 SpawnValores;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeasWait;
	public int startWait;
	public bool stop;
	int randEnemigo;
	 
	// Use this for initialization
	void Start () {
		StartCoroutine (waitSpawner ());
	}
	
	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range (spawnLeasWait, spawnMostWait);
	}
	IEnumerator waitSpawner(){
		yield return new WaitForSeconds (startWait);
		while (!stop) {
			randEnemigo = Random.Range (0.0f, 3.0f);
			Vector3 spawnPosition = new Vector3(1, Random.Range(-SpawnValores.x, SpawnValores), 1);

			Instantiate (enemigos [randEnemigo], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotatio);
			yield return new WaitForSeconds (spawnWait);

		}

	}

}
