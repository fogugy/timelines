using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Logger
{
	static FileStream fs = new FileStream (Application.dataPath, FileMode.Append);
	static StreamWriter sw = new StreamWriter (fs);
	
	public static void Log (string msg, bool isError)
	{
		if (isError) {
			msg += isError;
		}

		using (fs)
		using (sw) {
			sw.WriteLine (msg);
		}
	}
}
