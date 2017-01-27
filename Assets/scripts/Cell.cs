using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	static Dictionary<CellState, Material> _materials = new Dictionary<CellState, Material> ();

	CellState _state;
	public CellState State { 
		get{ return _state; } 
		set { 
			_state = value; 
			Render();
		} 
	}

	public Cell(){
		if (_materials.Count != 0) {
			return;
		}

		short i = 0;
		foreach (var mat in CellConfig.Materials) {
			_materials.Add((CellState)i++, mat);
		}
	}

	void Render(){
		var rnd = GetComponent<Renderer> ();
		rnd.material = _materials [State];
	}
}

public enum CellState {
	UP = 0,
	RIGHT,
	DOWN,
	LEFT
}