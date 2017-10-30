using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public UIBar uiBar;
	public GameObject GameOverUI;
	public static Vector3 startPosition;
	private float fillAmount;

	void Awake ()
	{
		startPosition = player.position;
		fillAmount = uiBar.bar.fillAmount;
		GameOverUI.SetActive(false);
	}

	public void Click ()
	{
		CharacterControl.gameOver = false;
		player.position = startPosition;
		uiBar.bar.fillAmount = fillAmount;
		GameOverUI.SetActive(false);
	}
}
