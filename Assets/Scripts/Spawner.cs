using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public PlayerController thePlayer;
    public float spawnFrequency;
    private float lastSpawned;
    private Vector3 lastPlayerPosition;

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
        Vector3 pos = lastPlayerPosition + new Vector3(lastPlayerPosition.x + 20, Random.Range(-2.5f, 10), 0);
        Instantiate(Obstacle, pos, Quaternion.identity);
    }
    }
