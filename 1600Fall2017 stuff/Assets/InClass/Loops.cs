using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public bool canPlay = true;
	public bool health = true;
	public bool stamina = true;
	public bool shield = false;
	public bool wound = true;
	public bool healthPickup = false;
	public float healing = 200;
	void Start()
	{
		StartCoroutine(PlayGame());
		StartCoroutine(Health());
		StartCoroutine(Stamina());
		StartCoroutine(Shield());
		StartCoroutine(Wound());
		StartCoroutine(healthpickup());
	}

	IEnumerator PlayGame(){
		while (canPlay)
		{
			print("Playing");
			yield return new WaitForSeconds(0.1f);
		}
		print("End Game");//while playing print playing continuously, after playing print end game once
	}

	IEnumerator Health(){
		while (health)
		{
			print("Healing");
			yield return new WaitForSeconds(0.1f);
		}
		print("Healing Pickup Expired");
	}

	IEnumerator Stamina(){
		while (stamina){
			print ("Gaining Stamina");
			yield return new WaitForSeconds(0.1f);
		}
		print("Stamina Pickup Expired");
	}

	IEnumerator Shield(){
		while (shield == true){
			print("Shield Up"); 
			yield return new WaitForSeconds(0.1f);
		}
		print("Shield Down");
	}

	IEnumerator Wound(){
		while (wound){
			print("Wounded");
			yield return new WaitForSeconds(0.1f);
		}
		print("Healed");
	}

	IEnumerator healthpickup(){
		while (healthPickup == true){
			healing += 20;
			yield return new WaitForSeconds(0.1f);
		}
		print("Pickup Expired");
	}
}
