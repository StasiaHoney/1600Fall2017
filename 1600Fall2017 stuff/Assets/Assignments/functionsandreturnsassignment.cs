using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionsandreturnsassignment : MonoBehaviour {
void Start () {
		myScore = ReturnNum(Health, Ammo);
		myPassword = ReturnPassword("ou812");
		NarnianRoyalty = ReturnNarnia("Edmund");
		Voltron = ReturnVoltron ("Season 3");
		Inktober = ReturnInktober (5);
	}
	
	public int myScore = 100;
	public int Health;
	public int Ammo;
	public string myPassword = "CoolStuff";

	int ReturnNum (int _num, int _num2){
		return _num + _num2;
	}

	string ReturnPassword (string _login){
		if(_login == "ou812"){
			return "Password Correct";
		} else {
			return "Incorrect";
		}		
	}

	public string NarnianRoyalty = "Lucy";
	string ReturnNarnia (string _Queens){
		if(_Queens == "Lucy") {
			return "Valiant";
		} else {
			return "False Royalty";
		}
	}

	public string Voltron = "Season 4";
	string ReturnVoltron (string _se4){
		if (_se4 == "Season 4"){
			return ":)";
		} else {
			return ":'(";
		}
	}

	public int Inktober = 31;
	int ReturnInktober (int _ink){
		if(_ink >= 15){
			return 31;
		} else {
			return 0;
		}
	}

	public int crouch;
	int ReturnCrouch (int _grab){
		if(_grab <= 50 ){
			return 0;
		} else {
			return 100;
		}
	}

	string ReturnRoommate (string _Katie){
		if(_Katie == "Nice"){
			return "Happy";
		} else {
			return "Grumpy";
		}
	}

	public string [] NarniaRoyalty = {"Peter", "Susan", "Edmund", "Lucy"}; 
	public void Narnia (string Royalty){
		print(this.name + NarniaRoyalty + "is Narnian Royalty");
	}

	public void Play(string character, int Health){
		print(this.name + character + " has " + Health + "% Health"); 
	}
	public void Plushie (string animal, string race){
		print(this.name + animal + " is a " + race);
	}
	
}


