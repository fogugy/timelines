using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : MonoBehaviour
{

	public string Name;

	GameObject Field;

	public LevelCtrl ()
	{
	}

	public LevelCtrl (string name)
	{
		Name = name;
	}

	void Start ()
	{
		InitField ();
	}

	void InitField ()
	{
		Field = Instantiate (FieldPrefab);
		Field.transform.parent = gameObject.transform;
		var fieldCtrl = FieldFactory.Get (Name);

	}
}
