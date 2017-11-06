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

	public enum PowerUpType
	{
		PowerUp,
		PowerDown,
		CollectCoin,
		Win
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
			//start the coroutine "CollectCoin"
				StartCoroutine (CollectCoin());
			break;

			case PowerUpType.Win:
				EndGame("You Win!");
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
	}
	void EndGame (string _text)
	{
		EndGameText.text = _text;
		gameOverUI.SetActive(true);
		CharacterControl.gameOver = true;
	}
}
