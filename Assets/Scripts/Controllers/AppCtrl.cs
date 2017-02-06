using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppCtrl : MonoBehaviour
{

	void Start ()
	{
		LoadConfig ();
		InitPrefabStorage ();
	}

	void LoadConfig ()
	{
		
	}

	void InitPrefabStorage ()
	{
		PrefabStorageCtrl.Load ();
	}
}