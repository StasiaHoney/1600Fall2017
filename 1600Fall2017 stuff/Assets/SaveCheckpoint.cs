using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckpoint : MonoBehaviour {

	Vector3 checkPoint;
	public Transform Player;
	string [] playerPrefsTitles = {"CheckpointX", "CheckpointY", "CheckpointZ"};
	void OnTriggerEnter()
	{
		checkPoint = transform.position;
		for (int i = 0; i < playerPrefsTitles.Length; i++)
		{
			PlayerPrefs.SetFloat(playerPrefsTitles[i], checkPoint[i]);
		}			
	}

	void Start()
	{
		Player.position = checkPoint;
		for (int i = 0; i < playerPrefsTitles.Length; i++)
		{
			checkPoint[i] = PlayerPrefs.GetFloat(playerPrefsTitles[i]);
		}		
	}
}
