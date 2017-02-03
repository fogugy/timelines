using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

abstract public class PrefabBase
{

	public string PrefabsPath { get; internal set; }
	public string XmlPath { get; internal set; }

	public static GameObject GetPrefab (string prefabName)
	{
		//TODO:uncomment and checkout error
		//return (GameObject)Resources.Load (Path.Combine (PrefabsPath, prefabName), typeof(GameObject));
		return new GameObject();
	}
}
