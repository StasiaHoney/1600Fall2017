using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

	public List <string> disneyPrincesses = new List<string>();
	public List<int> Age = new List<int>();
	void Start(){
		disneyPrincesses.Add("Mulan");//adds to List
		disneyPrincesses.Add("Rapunzel");
		disneyPrincesses.Add("Merida");
		disneyPrincesses.Add("Moana");
		disneyPrincesses.Insert(2, "Kida");//inserts to specific #
		disneyPrincesses.Remove("Merida"); //removes from list

		Age.Add(18); 
	}
	
	
}
