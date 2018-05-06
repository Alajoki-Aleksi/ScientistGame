using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {
	public GameObject canvas;
	public GameObject button;

	private GameObject player;
	private bool buttonCreated;


	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		buttonCreated = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null && buttonCreated == false) {
			Debug.Log("kuollut");
			GameObject newButton = Instantiate(button) as GameObject;
			newButton.transform.SetParent(canvas.transform, false);
			buttonCreated = true;
		}
	}
}
