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
        Vector3 pos = lastPlayerPosition + new Vector3(lastPlayerPosition.x + 20, Random.Range(-2.5f, 10), 0);
        Clone = Instantiate(Obstacle, pos, Quaternion.identity);

        int Randomizer = Random.Range(1, 7);

        if (Randomizer == 1)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[0];
        }
        if (Randomizer == 2)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[1];
        }
        if (Randomizer == 3)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[2];
        }
        if (Randomizer == 4)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[3];
        }
        if (Randomizer == 5)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[4];
        }
        if (Randomizer == 6)
        {
            Clone.GetComponent<SpriteRenderer>().sprite = ObstacleSprite[5];
        }
        
        
    }
    }
