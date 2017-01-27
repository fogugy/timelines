using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playfield : MonoBehaviour {

	public int FieldWidth { get; private set; }
	GameObject[,] cells;

	void Start () {
		Init ();
	}

	void Init(){
		FieldWidth = FieldConfig.FieldWidth;
		cells = new GameObject[FieldWidth, FieldWidth];

		var initialOffset = FieldWidth / 2f;
		var initialPos = new Vector3 (-initialOffset, 0f, -initialOffset);

		for (short i = 0; i < FieldWidth; i++) {
			for (short j = 0; j < FieldWidth; j++) {
				cells [i, j] = Instantiate (CellConfig.Prefab);
				cells [i, j].transform.position = initialPos + new Vector3 (1.1f * i, 0f, 1.1f * j);

				Cell cell = cells [i, j].GetComponent<Cell>();
				cell.State = CellState.LEFT;

				if (i % 3 == 0) {
					cell.State = CellState.UP;
				}

				if (i % 5 == 0) {
					cell.State = CellState.DOWN;
				}

				if ((j + i) % 5 == 0) {
					cell.State = CellState.RIGHT;
				}
			}
		}
	}
}
