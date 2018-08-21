using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    public AudioClip heloCall;
    private AudioSource audioSource;
    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Call"))
        {
            CallHeli();
        }

    }
    private void CallHeli()
    {
        audioSource.clip = heloCall;
        if(!audioSource.isPlaying)
        {
            audioSource.loop = false;
            audioSource.Play();
        }
        
    }
}
