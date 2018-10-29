﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

	// Use this for initialization
	public GameObject background1;
	public GameObject background2;
	public Transform generationPoint;
	public int backgroundType;

	void Start () {
		backgroundType = 0;
	}

	// Update is called once per frame
	void Update () {
		if (backgroundType == 0) {
			if (transform.position.x + 90 < generationPoint.position.x) {


				transform.position = new Vector3 (transform.position.x + 187.54f, transform.position.y + 14.783f, transform.position.z);
				Instantiate (background2, transform.position, transform.rotation);
				backgroundType = 1;
			}
		} else {
			if (transform.position.x + 40 < generationPoint.position.x) {

				//			transform.position = new Vector3(transform.position.x + 106f, transform.position.y, transform.position.z);
				//			transform.position = new Vector3(transform.position.x + 136f, transform.position.y + 15f, transform.position.z);

					transform.position = new Vector3(transform.position.x + 54.9f, transform.position.y - 14.783f, transform.position.z);
					Instantiate (background1, transform.position, transform.rotation);
					backgroundType = 0;

			}
		}

	}
}
