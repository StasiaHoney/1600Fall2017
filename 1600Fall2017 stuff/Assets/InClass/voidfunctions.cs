﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidfunctions : MonoBehaviour {

public string [] foxFood = {"Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Cake"};
public int [] foodCount = {10, 2, 30, 1, 2, 1};
	// Use this for initialization
	public virtual void Start () {
		Die();

		for(int i = 0; i < foxFood.Length; i++){
			Eat(foxFood[i], foodCount[i]);
		}
		Sleep();

	}

	void Die (){
		print(this.name + "Dies");
	}

	void Eat(string food, int ammount){ //things inside () are arugments
		print(this.name + " Likes to eat " + food);
		print(this.name + " Ate " + ammount);
	}
	
	void Sleep(){

	}
	// Update is called once per frame
	void Update () {
		
	}
}
