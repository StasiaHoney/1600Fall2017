using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public CharacterController characterControl;
	public static bool gameover = false;
	public float gravity = 9.81f;
	public float speed = 15;
	public float jump = 50;
	public Vector3 moveVector3;

	void Update()
	{
		moveVector3.y -= gravity * Time.deltaTime;

		if(characterControl.isGrounded && !gameover)
		{
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveVector3.y = jump * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		characterControl.Move(moveVector3);
	}
}
