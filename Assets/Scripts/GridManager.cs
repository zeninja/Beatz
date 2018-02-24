using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridManager : MonoBehaviour {

	public static GridSlot[] grid;
	public int numSlots;
	public int xOffset, yOffset;


	public GameObject gridSlot;

	public class GridSlot {
		public Vector3 position;
	}

	// Use this for initialization
	void Start () {
		grid = new GridSlot[numSlots];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetGrid() {
		for (int i = 0; i < numSlots; i++) {
			grid[i].position = new Vector2(xOffset * i, yOffset);
			GameObject slot = Instantiate (gridSlot) as GameObject;
			slot.transform.position = grid[i].position;
		}
	}
}
