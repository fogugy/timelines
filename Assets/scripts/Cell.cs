using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	CellState _state;
	public CellState State { 
		get{ return _state; } 
		set { 
			_state = value; 
			Render();
		} 
	}

	public Cell(){
	}
	public Cell(CellState state){
		State = state;
	}

	void Render(){
		
	}
}

public enum CellState {
	UP = 0,
	RIGHT,
	DOWN,
	LEFT
}