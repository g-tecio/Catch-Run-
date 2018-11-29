using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	Rigidbody2D player;

	bool grounded;
	public float jumpforce;
	public float dirX = 100f;
	public float dirLessX = -100f;
	public float moveSpeed = 300;
	bool touchButton = false;

	void Start () {
		player = GetComponent<Rigidbody2D>();
	}
	
	public void Jump(){
		if(grounded == true){
			player.AddForce(Vector2.up * jumpforce);
			grounded = false;
		}
	}

	// public void MovePlayerRight(){
	// 	if(touchButton == false){
	// 		player.AddForce(new Vector2(dirX * moveSpeed * Time.deltaTime, 0));
	// 		touchButton = true;
	// 	}
	// }

	// public void MovePlayerLeft(){
	// 	if(touchButton == true){
	// 		player.AddForce(new Vector2(dirLessX * moveSpeed * Time.deltaTime, 0));
	// 		touchButton = false;
	// 	}
	// }

	private void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Bottom")
		{
			grounded = true;
		}
	}
	

}
