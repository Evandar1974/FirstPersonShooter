using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public AudioClip heloCall;
    public GameObject spawnPoints;
    private AudioSource audioSource;
    private Transform[] spawnPoint;
    private Rigidbody body;
    public bool respawn;
	// Use this for initialization
	void Start ()
    {
        spawnPoint = spawnPoints.GetComponentsInChildren<Transform>();
        body = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(respawn == true)
        {
            ReSpawn();
        }
        if(Input.GetButton("Call"))
        {
            CallHeli();
        }
	}

    private void ReSpawn()
    {        
        int spawn = Random.Range(1, spawnPoint.Length);
        body.transform.position = spawnPoint[spawn].position;
        respawn = false;
    }
    private void CallHeli()
    {
        audioSource.clip = heloCall;
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}

