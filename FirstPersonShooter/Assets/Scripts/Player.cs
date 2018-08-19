using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject spawnPoints;
    private Transform[] spawnPoint;
    private Rigidbody body;
    public bool respawn;
	// Use this for initialization
	void Start ()
    {
        spawnPoint = spawnPoints.GetComponentsInChildren<Transform>();
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(respawn == true)
        {
            ReSpawn();
        }
	}

    private void ReSpawn()
    {
        int max = spawnPoint.Length;
        int spawn = (int)Random.Range(1f, max);
        body.transform.position = spawnPoint[spawn].position;
        respawn = false;
    }
}

