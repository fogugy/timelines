using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[XmlRoot ("FieldPrefabs")]
public class FieldPrefabs : PrefabBase
{
	public FieldPrefabs ()
	{
		PrefabsPath = "Field";
		XmlPath = "FieldConfig.xml";
	}

	public string FieldName { get; set; }

	public string CellName { get; set; }

	public List<string> PlayersNames { get; set; }
}