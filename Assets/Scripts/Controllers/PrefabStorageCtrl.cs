using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public static class PrefabStorageCtrl
{
	static string Folder = Path.Combine (Application.dataPath, "Config");

	public static FieldPrefabs Field { get; private set; }

	public static void Load ()
	{
		
	}

	public static void Save ()
	{
		
	}

	private static void LoadPrefab<T>(ref T prefab) where T : PrefabBase
	{
		var path = Path.Combine (Folder, prefab.XmlPath);
		var serializer = new XmlSerializer (typeof(T));
		var stream = new FileStream (path, FileMode.Open);
		prefab = serializer.Deserialize (stream) as T;
		stream.Close ();
	}
}
