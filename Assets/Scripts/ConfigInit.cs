using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigInit : MonoBehaviour
{
	public static System.Action OnInitDone { get; set; }

	public int FieldWidth = 9;
	public string FieldPrefabName = "playfield";

	public int CellStateCount = 4;
	public List<string> CellMaterialsNames = new List<string> ();
	public string CellPrefabName = "cell";

	void Start ()
	{
		Init ();
	}

	public void Init ()
	{
		InitCell ();
		InitField ();

		OnInitDone ();
	}

	void InitField ()
	{
		FieldConfig.FieldWidth = FieldWidth;
		FieldConfig.Prefab = GetResource<GameObject> (FieldPrefabName);
	}

	void InitCell ()
	{
		CellConfig.Prefab = GetResource<GameObject> (CellPrefabName);
		foreach (var matName in CellMaterialsNames) {
			CellConfig.Materials.Add (GetResource<Material> (matName));
		}
	}

	T GetResource<T> (string prefabName) where T : class
	{
		if (prefabName.Length == 0) {
			throw new UnityException ("Prefab name in config is empty");
		}
		return (Resources.Load (prefabName, typeof(T)) as T);
	}
}
