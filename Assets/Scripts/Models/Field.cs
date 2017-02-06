using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class Field : MonoBehaviour
{
	public string Name;

	List<Cell> Cells { get; set; }

	public Field ()
	{
		Cells = new List<Cell> ();
	}

	void Start ()
	{
		
	}
	 
}

[XmlRoot ("FieldCollection")]
public class FieldCollection
{
	[XmlArray ("Fields")]
	[XmlArrayItem ("Field")]
	public List<Field> List = new List<Field> ();
}