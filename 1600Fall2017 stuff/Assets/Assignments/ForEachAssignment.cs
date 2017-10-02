using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachAssignment : MonoBehaviour {

	//list used in foreach loop
	public List <string> vidGames;
	public int [] Age = {0,5,10,12,16,18};
	public string [] tvShows = {"Young Justic", "Voltron", "TrollHunters", "ATLA", "TLOK"};
	public string [] Kpop = {"Day6", "BTS", "Nu'est", "Got7", "Topp Dogg", "B.A.P", "Winner" };
	public string [] charactersUncharted = {"Nathan Drake", "Samuel Drake", "Elena Fisher", "Victor Sullivan", "Chloe Frazer", "Nadine Rose"}; 
	public string [] TLOUCharacters = {"Joel", "Ellie", "Tommy", "Sarah", "Marlene"};
	public string [] BioshockCharacters = {"Booker Dewitt", "Elizabeht", "Luteces", "Comstock", "Daisy Fitzroy"};
	public string [] twdCharacters = {"Lee", "Clementine", "Javi", "Gabe", "Kate", "Kenny", "Jane", "Luke"};
	public string [] UntilDawnCharacters = {"Sam", "Josh", "Jess", "Mike", "Matt", "Em", "Ash", "Chris", "Hannah", "Beth"};
	public string [] HorizonCharacters = {"Aloy", "Rost"};

	// Use this for initialization
	void Start () {
		vidGames.Add("Uncharted");
		vidGames.Add("The Last Of Us");
		vidGames.Add("Bioshock Infinite");
		vidGames.Add("The Walking Dead");
		vidGames.Add("Until Dawn");
		vidGames.Add("Horizon: Zero Dawn");

		foreach(string game in vidGames){
			print(game);
			//prints the value for every string in the list vidGames
		}

		foreach(int value in Age){
			print(value);
		}

		foreach(string show in tvShows){
			print(show);
		}
		
		foreach(string groups in Kpop){
			print(groups);
		}

		foreach(string uncharacters in charactersUncharted){
			print(uncharacters);
		}

		foreach(string tloucharries in TLOUCharacters){
			print(tloucharries);
		}

		foreach(string biocharries in BioshockCharacters){
			print(biocharries);
		}

		foreach(string twdcharries in twdCharacters){
			print (twdcharries);
		}

		foreach(string uncharries in UntilDawnCharacters){
			print(uncharries);
		}
		foreach(string horizoncharries in HorizonCharacters){
			print(horizoncharries);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
