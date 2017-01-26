using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigPrefabs : MonoBehaviour{
	public static string Yo;
}

public static class CellConfig {

	//cell
	public static Material[] CellMaterials;
	public static GameObject CellPrefab;

	//field
	public static int FieldWidth = 9;
}
