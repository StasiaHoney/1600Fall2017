﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RunGame : MonoBehaviour {
	public Toggle toggle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (toggle.isOn)
		{
			print("Can Play");
		} else{
			print("Can't Play");
		}
	}
}
