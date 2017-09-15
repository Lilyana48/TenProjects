using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed = 10f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);
			Debug.Log ("RIGHT");
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector2(-1,0) * moveSpeed * Time.deltaTime);
			Debug.Log ("LEFT");
		}
	}
	}

