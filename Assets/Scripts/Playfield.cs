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

		for (int i = 0; i < FieldWidth; i++) {
			for (int j = 0; j < FieldWidth; j++) {
				cells [i, j] = Instantiate (CellConfig.Prefab);
				cells [i, j].transform.position = initialPos + new Vector3 (1.1f * i, 0f, 1.1f * j);
			}
		}
	}
}
