using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public float barTime = 0.1f;
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
		while (bar.fillAmount < 1)
		{
			bar.fillAmount += ammountToAdd;
			yield return new WaitForSeconds(barTime);
		}
	}

	IEnumerator PowerDownBar () {
		float tempAmmount = powerLevel;
		float fillAmount = bar.fillAmount;
		while (tempAmmount > 0)
		{
			fillAmount = tempAmmount - ammountToAdd;
			bar.fillAmount = fillAmount;
			yield return new WaitForSeconds(barTime);
		}
	}
}
