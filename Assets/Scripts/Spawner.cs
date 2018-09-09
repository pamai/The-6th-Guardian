using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] objects;                // The prefab to be spawned.
    public float spawnTime = 6f;            // How long between each spawn.
    private Vector3 spawnPosition;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Spawn () {
        spawnPosition.x = Random.Range(-17, 17);
        spawnPosition.y = 0.5f;
        spawnPosition.z = Random.Range(-17, 17);

        Instantiate(objects[0], spawnPosition, Quaternion.identity);
    }
}
