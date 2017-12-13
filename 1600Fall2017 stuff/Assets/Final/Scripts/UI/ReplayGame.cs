using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Transform objects;
	public UIBar uiBar;
	public GameObject GameOverUI;
	public static Vector3 startPosition;
	private float fillAmount;
	public DestroyObject active1;
	public DestroyObject active2;
	public DestroyObject active3;
	public DestroyObject active4;
	public DestroyObject active5;
	public DestroyObject active6;
	public DestroyObject active7;
	public DestroyObject active8;
	

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

		active1.powerup.SetActive(true);
		active2.powerup.SetActive(true);
		active3.powerup.SetActive(true);
		active4.powerup.SetActive(true);
		active5.powerup.SetActive(true);
		active6.powerup.SetActive(true);
		active7.powerup.SetActive(true);
		active8.powerup.SetActive(true);
	}
}
