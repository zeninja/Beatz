using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// PROCESS:
	// 1. SET GAME RULES (NUM PLAYERS, BPM, NUM ROUNDS?)
	// 2. COUNT-IN
	// 3. FIGNT!

	public delegate void Beat();
	public static event Beat OnBeat;

	static GameManager instance;

	public static List<GameObject> _players;
	static int numPlayers = 2;
	public GameObject playerPrefab;

	float bpm = 100;
	float ms;

	// Use this for initialization
	void Awake () {
		if(instance != null) Destroy(this);
		instance = this;
	}

	void Start() {
		_players = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)) {
			StartCoroutine(RunRound());
		}
	}

	IEnumerator RunRound() {
		Reset();

		yield return StartCoroutine(SpawnPlayers());
		yield return StartCoroutine(CountIn());
		yield return StartCoroutine(Metronome());
	}

	IEnumerator SpawnPlayers() {
		// do fancy camera stuff here later maybe?
		GameObject player1 = Instantiate(playerPrefab) as GameObject;
		player1.GetComponent<PlayerSettings>().playerNum = 1;
		player1.GetComponent<PlayerSettings>().playerColor = Color.red;
		player1.GetComponent<PlayerSettings>().stance = PlayerController.Stance.attack;
		_players.Add(player1);

		GameObject player2 = Instantiate(playerPrefab) as GameObject;
		player2.GetComponent<PlayerSettings>().playerNum = 2;
		player2.GetComponent<PlayerSettings>().playerColor = Color.blue;
		player2.GetComponent<PlayerSettings>().stance = PlayerController.Stance.defense;
		_players.Add(player2);
		yield return null;
	 }

	 IEnumerator CountIn() {
		Debug.Log("Okay. . .");
		yield return new WaitForSeconds(ms);
		Debug.Log("3.");
		yield return new WaitForSeconds(ms);
		Debug.Log("2.");
		yield return new WaitForSeconds(ms);
		Debug.Log("1.");
		yield return new WaitForSeconds(ms);
		Debug.Log("Let's jam!");
	 }

	 IEnumerator Metronome() {
		OnBeat();
		yield return new WaitForSeconds(ms);
		StartCoroutine(Metronome());
	 }

	 void Reset() {
	 	ms = 60/bpm;
	 }
}
