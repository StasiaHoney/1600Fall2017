using UnityEngine;

public class PowerUps : MonoBehaviour {
	void OnTriggerEnter()
	{
		gameObject.SetActive(false); 
	}
}
