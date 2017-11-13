using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

	public enum Pickuptype
	{
		PowerUp,
		PowerDown,
		Jump,
		CollectCoin,
		Win,
		Speed

	}	
	public Pickuptype pickup;
	void OnTriggerEnter()
	{
		switch(pickup)
		{
			case Pickuptype.Powerup:
			StartCoroutine(PowerupBar());
			break;
		}
	}
	IEnumerator PowerupBar (){

	}
}
