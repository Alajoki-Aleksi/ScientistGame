using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {
	public GameObject canvas;
	public GameObject restartButton;
	public GameObject quitButton;

	private GameObject player;
	private bool buttonsCreated;


	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		buttonsCreated = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null && buttonsCreated == false) {
			Debug.Log("kuollut");
			GameObject newRestartButton = Instantiate(restartButton) as GameObject;
			GameObject newQuitButton = Instantiate(quitButton) as GameObject;
			newRestartButton.transform.SetParent(canvas.transform, false);
			newQuitButton.transform.SetParent(canvas.transform, false);
			buttonsCreated = true;
		}
	}
}
