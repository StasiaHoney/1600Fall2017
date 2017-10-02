using System.Collections.Generic;
using UnityEngine;

public class ListAssignment : MonoBehaviour {

	public List <string> disneyPrincesses = new List<string>();
	public List<int> Age = new List<int>();
	void Start(){
		disneyPrincesses.Add("Mulan");//adds to List
		disneyPrincesses.Add("Rapunzel");
		disneyPrincesses.Add("Merida");
		disneyPrincesses.Add("Moana");
		disneyPrincesses.Insert(2, "Kida");//inserts to specific #
		disneyPrincesses.Remove("Merida"); //removes from list

		Age.Add(1);
		Age.Add(9);
		Age.Insert(1, 5);
		Age.Add(12);
		Age.Add(16);
		Age.Add(18);
		Age.Add(21);
		Age.Remove(21);		
	}
	
	
}