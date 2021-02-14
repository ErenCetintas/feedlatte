﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded2 : MonoBehaviour {
	GameObject Player;
	// Use this for initialization
	void Start () {
		Player = gameObject.transform.parent.gameObject;
	}

	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.collider.tag == "Ground") {
			Player.GetComponent<PlayerMovement2> ().isGrounded = true;
			Debug.Log ("yerde");
		}

	}
	private void OnCollisionExit2D(Collision2D collision){
		if (collision.collider.tag == "Ground") {
			Player.GetComponent<PlayerMovement2> ().isGrounded = false;
		}
	}

}
