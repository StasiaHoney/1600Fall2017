using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCall : MonoBehaviour {

	public ParticleSystem win;
	
	void OnTriggerEnter()
	{
		win.Emit(100);
	}
}
