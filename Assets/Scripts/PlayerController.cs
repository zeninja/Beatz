using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public enum Stance { attack, defense };
	public Stance myStance = Stance.attack;

	public enum PlayerState { attack, wait, block, counter, empty };
	public PlayerState playerState = PlayerState.empty;

	float inputHorizontal, inputVertical;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ManageInput();
		CheckState();
	}

	void ManageInput() {
		inputHorizontal = Input.GetAxisRaw("Horizontal");
		inputVertical   = Input.GetAxisRaw("Vertical");



	}

	void CheckState() {
		// I JUST REALIZED, I CAN GIVE EACH OF THESE THINGS SELECTION PRIORITY BY ADDING RETURN AFTER THEM
		// THAT MEANS, AS SOON AS ONE MATCHES, IT'LL IMMEDIATELY JUMP OUT OF THE LOOP AND THAT ONE WILL BE CHOSEN

		switch(myStance) {
			case Stance.attack:
				if(inputVertical < 0) {
					playerState = PlayerState.wait;
					return;
				} 
				if(inputVertical > 0) {
					playerState = PlayerState.attack;
					return;
				}
				break;
			case Stance.defense:
				if(inputHorizontal > 0) {
					playerState = PlayerState.counter;
					return;
				}
				if(inputHorizontal < 0) {
					playerState = PlayerState.block;
					return;
				}
				break;
			default:
				playerState = PlayerState.empty;
				break;
		}
	}

	public void SetStance(Stance newStance) {
		myStance = newStance;
	}

	public PlayerState EvaluateState() {
		CheckState();
		return playerState;
	}
}
