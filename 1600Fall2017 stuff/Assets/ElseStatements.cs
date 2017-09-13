using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElseStatements : MonoBehaviour {

	public bool Klance;
	public bool Life;
	public bool Love;
	public Text input;
	private string password = "Dear_Evan_Hansen";
	public float num1;
	public bool Voltron_Season_4 = false;
	public bool Galra_Keith;
	public string BlueLion;
	public string RedLion;
	public string GreenLion;
	// Use this for initialization
	void Start () {
		if (Klance){
			print("Canon!");
		} else {
			print("We can dream");
		}

		if (Life){
			print("Alive");
		} else {
			print("6 feet under");
		}

		if (Love){
			print("Happy");
		} else {
			print("Heartbroken");
		}

		/*if (input.text == password){
			print("Correct password");
		} else {
			print("Incorrect Passowrd");
		}*/

		if (num1 == 3.14){
			print("Pi!");
		} else {
			print("No pi for you");
		}

		if(Voltron_Season_4){
			print("Finally!");
		} else {
			print("*Sobs self to sleep");
		}

		if(Galra_Keith){
			print("funnier than human Keith");
		} else {
			print("Loner");
		}

		if(BlueLion == "Lance"){
			print("Sharpshooter");
		} else {
			print( "Allura");
		}

		if(RedLion == "Keith"){
			print("Shiro Black");
		} else{
			print("Lance");
		}

		if(GreenLion == Pidge){
			print("Katie");
		}else {
			print("Other Alien chick");
		}
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
