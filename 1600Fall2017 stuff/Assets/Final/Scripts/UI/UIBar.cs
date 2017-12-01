using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public Text coinNum;
	public Text EndGameText;
	public int totalCoinValue;
	public int coinValue = 30;
	public GameObject gameOverUI;
	public static bool gameOver;
	public float ammountToAdd = 0.1f;
	public float powerLevel = 0.01f;
	public float plusSpeed = 10;
	public float speed;
	private Vector3 moveVector;

	public enum PowerUpType
	{
		PowerUp,
		PowerDown,
		Jump,
		CollectCoin,
		Win,
		Speed
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

			case PowerUpType.CollectCoin:
				StartCoroutine (CollectCoin());
			break;

			case PowerUpType.Win:
				EndGame("You Win!");
			break;

			case PowerUpType.Speed:
				StartCoroutine (SpeedPickup());
			break;
		}
	}
	IEnumerator CollectCoin () {
		print ("Coint Collected");
		totalCoinValue = int.Parse(coinNum.text);
		int tempAmmount = totalCoinValue + coinValue;
		while(totalCoinValue <= tempAmmount)
		{
			coinNum.text = (totalCoinValue++).ToString();
			yield return new WaitForFixedUpdate();
		}
	}

	IEnumerator SpeedPickup ()
	{
		return null;
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
		
		if(bar.fillAmount == 0)
		{
			EndGame("Game Over");
		}

		if(moveVector.y <= -1)
		{
			EndGame("Replay");
		}
	}
	void EndGame (string _text)
	{
		EndGameText.text = _text;
		gameOverUI.SetActive(true);
		CharacterControl.gameOver = true;
	}
}
