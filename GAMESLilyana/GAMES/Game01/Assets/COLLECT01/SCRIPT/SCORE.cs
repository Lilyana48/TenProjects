using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour {

	public int contador;
	public Text score;	// Use this for initialization


	void Start () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
		contador = contador + 1;
		score.text = "SCORE: " + contador;
	}

	public void Awake()
	{
		contador = 0;
		score.text = "SCORE: " + contador;

	}
	// Update is called once per frame
	void Update () {
		
	}
}
