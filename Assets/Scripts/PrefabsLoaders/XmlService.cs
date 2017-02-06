using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public static class XmlService
{
	static readonly string XmlPath = Path.Combine (Application.dataPath, "Data");
	static readonly string FieldCollection = "FieldCollection.xml";

	public static FieldCollection LoadFields ()
	{
		var srlz = new XmlSerializer (typeof(FieldCollection));
		using (var fs = new FileStream (Path.Combine (XmlPath, FieldCollection), FileMode.OpenOrCreate)) {
			return srlz.Deserialize (fs) as FieldCollection;
		}
	}

	public static void SaveFields (FieldCollection fields)
	{
		var srlz = new XmlSerializer (typeof(FieldCollection));
		using (var fs = new FileStream (Path.Combine (XmlPath, FieldCollection), FileMode.Create)) {
			srlz.Serialize (fs, fields);
		}
	}
}
