using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatements : MonoBehaviour {

	public bool canPlayGame = false;
	public Text input;
	private string password = "Evan_Hansen";
	
	public int num1 = (7);
	public int num2 = (10);
	public int value = (70);

	public bool canPlay;

	public int num3;
	public int num4;
	public int value2;

	public bool canMurder;

	public int myage;
	public int momsAge;
	public int papasAge;
	public int KatsAge;

	public bool Klance;
	public bool Shiro;
	void Start()
	{
		if (num1*num2 == 70)
		{
			print(70);
		}	

		if (input.text == password)
		{
			print("You know the password");
		}
	}
	
}