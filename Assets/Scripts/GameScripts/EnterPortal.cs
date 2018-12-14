using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPortal : MonoBehaviour {

	private Transform destination;
	public GameObject portal;
	bool isRight;
	bool isLeft;

	// Use this for initialization
	void Start () {
		if(isRight == false){
			destination = GameObject.FindGameObjectWithTag("PortalLeft").GetComponent<Transform>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Player"){
			other.transform.position = new Vector2(destination.position.x, destination.position.y);
		}
	}
}
