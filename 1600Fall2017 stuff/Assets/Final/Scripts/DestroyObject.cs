﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public GameObject powerup;
 	void OnTriggerEnter()
	{
		powerup.SetActive (false);
	}
}
