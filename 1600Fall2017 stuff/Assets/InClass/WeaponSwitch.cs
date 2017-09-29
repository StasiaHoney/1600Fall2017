using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitchs : MonoBehaviour {

	public string [] weapons;
	//public int i = 0; //i short for indexer 

	public void MyWeaponsSwitch (int i){
		switch (weapons [i])
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;

			default:
				print("You have no other weapons.");
				break;
		}
	}
}
