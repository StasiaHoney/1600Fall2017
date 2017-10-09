using UnityEngine;

public class MathFunctions : MonoBehaviour {

	// Use this for initialization
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

	public void Play(string character, int Health){ //the vars inside the () are called arugments, you can have up to four
		//inside void functions you can do all sorts of things with loops and things like this.
		print(this.name + character + " has " + Health + "% Health"); //ouput ie. Ellie has 100% health
	}
	
}
