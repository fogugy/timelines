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

		for (int i = 0; i < FieldWidth; i++) {
			for (int j = 0; j < FieldWidth; j++) {
				cells [i, j] = Instantiate (CellConfig.Prefab);
			}
		}
	}
}
