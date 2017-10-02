using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public List<GameObject> myWeapons;

	void OnTriggerEnter(Collider _weapon)
	{
		myWeapons.Add(_weapon.gameObject);
	}
	public void MyWeaponSwitch (int i){
		switch (myWeapons[i].name)
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;

			case "RayGun":
				print("Ray Gun");
				break;	

			default:
				print("You have no other weapons.");
				break;
		}
	}
}
