using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
	public bool IsAvailable { get; set; }

	public CellState State { get; set; }

	public Cell ()
	{
		IsAvailable = false;
		State = CellState.Normal;
	}

	public Cell (bool available)
	{
		IsAvailable = available;
	}

	public void ToggleAvailability (bool? state)
	{
		if (state != null) {
			IsAvailable = (bool)state;
			return;
		}

		IsAvailable = !IsAvailable;
	}

	public void SetState (CellState state)
	{
		State = state;
	}
}

public enum CellState
{
	Normal,
	Red,
	Blue,
	Yellow,
	Green
}