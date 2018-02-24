using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour {

	// RULES:
	// ONE PLAYER ATTACKS. ONE PLAYER DEFENDS. 
	// THE GOAL OF EACH PLAYER IS TO GET THE HERO TO THEIR SIDE OF THE ROOM
	// THE "ATTACKING" PLAYER PLAYS AS THE HERO. THE DEFENDING PLAYER PLAYS AS THE GUARDS
	// THE ATTACKING PLAYER CAN EITHER ATTACK OR WAIT.
	// THE DEFENDING PLAYER CAN EITHER DODGE OR COUNTER.

	// WAITING INSTEAD OF ATTACKING HAS NO CONSEQUENCES (ATTACKING IS FAVORED, BUT OPTIONAL, YOU WANT TO TIME IT PROPERLY)
	// ATTACKING INTO A DODGE MOVES THE ATTACKER FORWARD AND THE DEFENDER BACK
	// ATTACKING INTO A COUNTER SWITCHES THE ROLES OF THE PLAYERS

	// Use this for initialization
	void Start () {
//		GameManager.Beat += EvaluateCombat();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EvaluateCombat() {
		// should create player states (attack/defense (or whatever))
		// and then can use those in input class to prevent overlapping input since they're separated by axis


	}
}