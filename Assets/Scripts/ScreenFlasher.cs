using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFlasher : MonoBehaviour {

	public CanvasGroup canvasGroup;
	bool flash;
	
	// Use this for initialization
	void Start () {
		GameManager.OnBeat += FlashScreen;
	}
	
	// Update is called once per frame
	void Update () {
		if(flash) {
			canvasGroup.alpha = canvasGroup.alpha - Time.deltaTime;
			if(canvasGroup.alpha <= 0) {
				flash = false;
				canvasGroup.alpha = 0;
			}

		}
	}

	void FlashScreen() {
		flash = true;
		canvasGroup.alpha = 1;
	}
}
