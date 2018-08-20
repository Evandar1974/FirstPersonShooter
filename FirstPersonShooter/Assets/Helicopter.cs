using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    public AudioClip heloCall;
    // Use this for initialization
    void Start () {
		
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
        
    }
}
