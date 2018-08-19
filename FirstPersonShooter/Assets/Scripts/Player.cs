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
        int spawn = Random.Range(1, spawnPoint.Length);
        body.transform.position = spawnPoint[spawn].position;
        respawn = false;
    }
}

