using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFunctionsAssignment : MonoBehaviour {

	public string [] TLOUcharacter = {"Ellie", "Joel", "Tommy", "David"}; //these can be used inside the void function
	public int [] tlouHealth = {100, 30, 100, 50};
	public void Play(string character, int Health){ //the vars inside the () are called arugments, you can have up to four
		//inside void functions you can do all sorts of things with loops and things like this.
		print(this.name + character + " has " + Health + "% Health"); //ouput ie. Ellie has 100% health
	}
	
	public string [] plush = {"Carlton", "Mabel", "Tamago", "Errol"};
	public string [] species = {"Dog", "Cat", "Cat", "Owl"};

	public void Plushie (string animal, string race){
		print(this.name + plush + " is a " + species); // output ie. Mabel is a Cat
	}
	public virtual void Start () {
		for (int i = 0; i < TLOUcharacter.Length; i++) //these for loops allow the arrays to be cycled through all elements
		{
			Play(TLOUcharacter[i], tlouHealth[i]);
		}

		for (int i = 0; i < plush.Length; i++)
		{
			Plushie(plush[i], species[i]);
		}
	}
}
