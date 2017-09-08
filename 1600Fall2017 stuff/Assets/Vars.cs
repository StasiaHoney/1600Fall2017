using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vars : MonoBehaviour {

	public float health = 100;

	void Start () {
		// health = 200;
	}
	
	void OnTriggerEnter()
	{
		health += 20;
	}

	void Update () {
		// if (health > 0)
		// {
		// 	health -= 0.1f;
		// } else
		// {
		// 	print("You Died!");
		// }
	}
}
