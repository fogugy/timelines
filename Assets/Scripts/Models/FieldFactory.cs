using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FieldFactory
{
	public static FieldCollection Collection = new FieldCollection ();

	static FieldFactory ()
	{
		Collection = XmlService.LoadFields ();
	}

	public static Field Get (string idName)
	{
		return Collection.List.Find (x => x.Name == idName);
	}

	public static void Save (Field field)
	{
		var oldField = Collection.List.Find (x => x.Name == field.Name);
		Collection.List.Remove (oldField);
		Collection.List.Add (field);
		Collection.List.Sort ();
		XmlService.SaveFields (Collection);
	}
}
