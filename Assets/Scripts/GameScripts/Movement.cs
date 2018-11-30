using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float moveSpeed = 300;
	public GameObject character;

	private Rigidbody2D characterBody;
	//private float ScreenWidth;

	void Start () {
		//enabled = true;
		//ScreenWidth = Screen.width;
		characterBody = character.GetComponent<Rigidbody2D>();
	}
	

	// void Update () {
	// 	int i = 0;
	// 	while (i < Input.touchCount)
	// 	{
	// 		if(Input.GetTouch (i).position.x > ScreenWidth/2){
	// 			RunCharacter(2.0f);
	// 		}
	// 		if(Input.GetTouch (i).position.x < ScreenWidth/2){
	// 			RunCharacter(-2.0f);
	// 		}
	// 	}
	// }

	// void FixedUpdate() {
	// 	#if UNITY_EDITOR
	// 	RunCharacter(Input.GetAxis("Horizontal"));
	// 	#endif
	// }

	public void RunCharacterRight(float horizontalInput = 2.5f){
		characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
	}

	public void RunCharacterLeft(float horizontalInput = -2.5f){
		characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
	}
}
