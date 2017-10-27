using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public GameObject gameOverUI;
	public static bool gameOver;
	public Image bar;
	public float ammountToAdd = 0.1f;
	public float powerLevel = 0.01f;

	public enum PowerUpType
	{
		PowerUp,
		PowerDown
	}

	public PowerUpType powerUp;
	void OnTriggerEnter () {

		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine (PowerUpBar());
			break;

			case PowerUpType.PowerDown:
				StartCoroutine (PowerDownBar());
			break;
		}
	}

	IEnumerator PowerUpBar () {
		float tempAmmount = bar.fillAmount + powerLevel;
		if (tempAmmount > 1){
			tempAmmount = 1;
		}
		while (bar.fillAmount < tempAmmount)
		{
			bar.fillAmount += ammountToAdd;
			yield return new WaitForSeconds(ammountToAdd);
			
		}
	}

	IEnumerator PowerDownBar () {
		float tempAmmount = bar.fillAmount - powerLevel;
		if(tempAmmount <= 0){
			tempAmmount = 0;
		}
		while (bar.fillAmount > tempAmmount)
		{
			bar.fillAmount -= ammountToAdd;
			yield return new WaitForSeconds(ammountToAdd);
		}
		
		if(bar.fillAmount == 0){
			gameOverUI.SetActive(true);
			CharacterControl.gameOver = true;
		}
	}
}
