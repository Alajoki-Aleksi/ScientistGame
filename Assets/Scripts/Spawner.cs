using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public PlayerController thePlayer;
    public float spawnFrequency;
    private float lastSpawned;
    private Vector3 lastPlayerPosition;

    public Sprite[] ObstacleSprite;

    public GameObject Obstacle;

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastSpawned > spawnFrequency)
        {
            lastSpawned = Time.time;
            SpawnObstacle();
        }
        lastPlayerPosition = thePlayer.transform.position;
    }

    public void SpawnObstacle()
    {
        GameObject Clone;
        Vector3 pos = lastPlayerPosition + new Vector3(30, Random.Range(-2.5f, 10), 0);
        Clone = Instantiate(Obstacle, pos, Quaternion.identity);

		int backgroundType = GameObject.Find ("BackgroundGenerator").GetComponent<BackgroundGenerator> ().backgroundType;
		Debug.Log ("Background type: " + backgroundType);

		if (backgroundType == 1) {
			int Randomizer = Random.Range (1, 8);
			if (Randomizer == 1) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [0];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 2) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [1];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 3) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [2];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 4) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [3];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 5) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [4];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 6) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [5];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 7) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [6];
				Clone.AddComponent<PolygonCollider2D> ();
			}
		} else {
			int Randomizer = Random.Range (1, 6);
			if (Randomizer == 1) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [7];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 2) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [8];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 3) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [9];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 4) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [10];
				Clone.AddComponent<PolygonCollider2D> ();
			}
			if (Randomizer == 5) {
				Clone.GetComponent<SpriteRenderer> ().sprite = ObstacleSprite [11];
				Clone.AddComponent<PolygonCollider2D> ();
			}
		}
        
        
        
    }
    }
