using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ConfigInit.OnInitDone += CreatePlayField;
	}
	
	void CreatePlayField(){
		Instantiate (FieldConfig.Prefab);
	}
}
