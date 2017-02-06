using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

abstract public class PrefabBase
{

	public static string PrefabsPath { get; internal set; }

	public string XmlPath { get; internal set; }

	public static GameObject GetPrefab (string prefabName)
	{
		return (GameObject)Resources.Load (Path.Combine (PrefabsPath, prefabName), typeof(GameObject));
	}

	public T LoadFromXml<T> () where T : new()
	{
		var serializer = new XmlSerializer (this.GetType ());
		var fileStream = new FileStream (Path.Combine (Application.dataPath, XmlPath), FileMode.Open);
		return (T)serializer.Deserialize (fileStream);
	}
}
