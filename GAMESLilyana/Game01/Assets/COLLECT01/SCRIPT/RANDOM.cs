using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM : MonoBehaviour {

	public GameObject enemy;

	private int enemies = 0;
	// Use this for initialization
	void Start () {

	
		for (enemies = 0; enemies <= 9; enemies++) {
			Vector2 position =new Vector2(Random.Range(-9.0f,9.0f),Random.Range(-4.0f,4.0f));
			Instantiate(enemy,position,Quaternion.identity);
		}
	}

	void Update () {



	}
}
