using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

abstract public class PrefabBase
{

	public static string PrefabsPath { get; internal set; }
	public string XmlPath { get; internal set; }

	public static GameObject GetPrefab (string prefabName)
	{
		return (GameObject)Resources.Load (Path.Combine (PrefabsPath, prefabName), typeof(GameObject));
	}
}
