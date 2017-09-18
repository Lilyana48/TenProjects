using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {


	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector2(0, 1) * moveSpeed * Time.deltaTime);
			Debug.Log ("UP");
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector2(0,-1) * moveSpeed * Time.deltaTime);
			Debug.Log ("DOWN");
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector2(-1,0) * moveSpeed * Time.deltaTime);
			Debug.Log ("LEFT");
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector2(1,0) * moveSpeed * Time.deltaTime);
			Debug.Log ("RIGHT");
		}

	}
}



//public class Random : MonoBehaviour {

//	public int spacing = 100; 
//	public Vector2 playerPos = Vector2.zero;
//	public int speed = 5; 

// Use this for initialization
//	void Start () {
//		playerPos = transform.position;
//	}

// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown(KeyCode.W))
//			playerPos.y += spacing;
//		if (Input.GetKeyDown(KeyCode.S))
//			playerPos.y -= spacing;
//		if (Input.GetKeyDown(KeyCode.A))
//			playerPos.x -= spacing;
//		if (Input.GetKeyDown(KeyCode.D))
//			playerPos.x += spacing;

//		transform.position = Vector2.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
//	}
//}