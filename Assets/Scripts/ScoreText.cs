using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public Text scoreText;
	private double score;
	private GameObject player;

	// Use this for initialization
	void Start () {
		//PlayerController speedController = go.GetComponent <PlayerController> ();
		score = 0;
		player = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			score += 0.5;
			scoreText.text = "Score: " + System.Math.Floor(score / 10);
		}
	}
}
