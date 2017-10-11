using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform player;
	
	// Update is called once per frame
	void Update () {
		Agent.destination = player.position;
	}

	public void Stun (float _speed) {
		Agent.speed = _speed;
	}
}
