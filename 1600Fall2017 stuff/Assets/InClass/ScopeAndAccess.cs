using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {
	private int health = 100;
	public int score = 100;
	//things in class can be seen by class and boxes(functions)
	protected int hitList = 10; //only child functions can see this var
	string thing1 = "Thing 1.";
	void Box ()
	{
			int newScore = 10;
			print(newScore);
			//things inside start can't be seen outside box (functions)
			string thing2 = "Thing 2.";
			thing1 = "Fun"; //thing1 can go inside box thing2 can't leave box

		void Box2 (){ //you can have functions inside of functions
			string foxInBox = "Our Game is done Sir, thank you for a lot of fun, Sir.";
			print(thing2);
		}		

		Box2 ();
	}

	void NewBox (){
		thing1 = "new thing";
	}
}
//we put things inside boxes to protect them
