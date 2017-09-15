using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

	[SerializeField] GameObject Enemy;


	// Use this for initialization
	void Start () {
		
		
				for(int i=-5; i <5 ; i ++){
					for (int s = -1; s <3 ; s++) {

						Instantiate (Enemy, new Vector3 (i, s, 0), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
