using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioClip beatSound;

	// Use this for initialization
	void Start () {
		GameManager.OnBeat += PlayBeat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlayBeat() {
		GetComponent<AudioSource>().PlayOneShot(beatSound);
	}
}
