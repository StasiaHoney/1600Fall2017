using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatements : MonoBehaviour {

	public Text input;
	private string password = "G@m3rG33k";
	
	void Update ()
	{
		if (input.text == password)
		{
			print("You know the password");
		}
	}
}