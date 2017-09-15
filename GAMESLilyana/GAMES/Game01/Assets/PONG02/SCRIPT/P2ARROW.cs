using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2ARROW : MonoBehaviour {

	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector2(0, 1) * moveSpeed * Time.deltaTime);
			Debug.Log ("UP");
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector2(0,-1) * moveSpeed * Time.deltaTime);
			Debug.Log ("DOWN");
		}
	}
}
