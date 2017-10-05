using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAssignment : MonoBehaviour {

	//this is a class everything can be seen by everything in the script here
	//public means other scripts can see it
	//private means that only this script can see it
	//protected means that only the child scripts (and this script) can see it
	//things here can go inside boxes in this script

	public string Katie = "Roommate"; //Katie can go inside start and other functions

	// Use this for initialization
	void Start () {
		//start is basically a box. things inside this box cannot be seen outside the box.
		//things can go into a box but cannot leave it's box.
		//you can make boxes in boxes (functions in functions)
		//can't make things public in functions/boxes

		string Ana = "Me"; //I can't leave the box so I can't say hi to Katie
		Katie = "*Says* Hello";	//but Katie can say hi to me

			void Box() { // new function inside start
				string Carlton = "My Grumpy Cat Plush";
				Katie = "Pets Carlton"; // we can both pet the kitty but the kitty can't come say hi to us.
				Ana = "Pets Carlton";
			}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
