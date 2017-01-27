using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigInit : MonoBehaviour {

	public int CellStateCount = 4;
	public List<string> CellMaterialsNames = new List<string> ();
	public string CellPrefabName = "";

	void Start()
	{
		InitConfigPrefabs();
	}

	//private
	void InitConfigPrefabs() 
	{
		InitPrefabs();
		InitCellMaterials();
	}

	void InitPrefabs()
	{
		CellConfig.Prefab = GetResource<GameObject> (CellPrefabName);
	}

	void InitCellMaterials() 
	{
		foreach (var matName in CellMaterialsNames) {
			CellConfig.Materials.Add (GetResource<Material> (matName));
		}
	}

	T GetResource<T>(string prefabName) where T : class
	{
		if (prefabName.Length == 0) {
			throw new UnityException ("Prefab name in config is empty");
		}
		return (Resources.Load(prefabName, typeof(T)) as T);
	}
}
