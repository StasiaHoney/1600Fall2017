using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

	public bool a;
	public bool b;
	public bool c;
	public bool trueLove;
	public bool Fantasy;
	public bool wound;
	public bool heal;
	public bool grade;
	public bool school;
	public bool life;
	public bool friends;
	

	// Use this for initialization
	void Start () {
		if (a && b){ // both have to be true to be true
			print("Alphabet");
		}

		if(a || b){ // if non zero, true
			print("Letters");
		}

		if(!(a && b)){ // ! == not
			print("Void");
		}

		if (c && b && a){ //can use more than one var
			print("Wow");
		}

		if (a || b || c){
			print("Light Bulb");
		}

		if (!(trueLove && Fantasy)){
			print("Reality");
		} else {
			print ("tears");
		}

		if (!(wound && heal)){
			print("Healed");
		}

		if (life||friends){
			print("Happy");
		}

		if (school && grade){
			print("diploma");
		}

		if (!(school && grade)){
			print("Parent's Basement");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
