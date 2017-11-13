﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterController;
	public float gravity = 9.81f;
	public Vector3 moveVector3;
	public float speed = 10;
	public float jumpForce = 1000;
	void Start () {
		
	}
	
	void Update () {


		if (characterController.isGrounded){

			if (Input.GetKeyDown(KeyCode.Space)){
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		
		characterController.Move(moveVector3);
		moveVector3.y -= gravity * Time.deltaTime;
		
	}
}
