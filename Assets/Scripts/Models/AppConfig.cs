using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AppConfig
{
	public static AppMode Mode { get; private set; }

	public static void LoadConfig ()
	{
		
	}
}

public enum AppMode
{
	Dev,
	Qa,
	Prod
}