﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterController;
	public static bool gameOver = false;
	public float gravity = 9.81f;
	public float speed = 10;
	public Vector3 moveVector3;
	public float jumpForce = 50;
	void Update () {
		moveVector3.y -= gravity * Time.deltaTime;
		if (characterController.isGrounded && !gameOver)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		characterController.Move(moveVector3);
	}
}
