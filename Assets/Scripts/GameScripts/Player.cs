using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody2D player;
	public GameObject destroyObstacleObj;

	bool grounded;
	public float jumpforce;
	public float dirX = 100f;
	public float dirLessX = -100f;
	public float moveSpeed = 300;

	void Start () {
		player = GetComponent<Rigidbody2D>();
	}
	
	public void Jump(){
		if(grounded == true){
			player.AddForce(Vector2.up * jumpforce);
			//transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
			grounded = false;
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Bottom")
		{
			grounded = true;
		}

		if(other.gameObject.tag == "Platform")
		{
			grounded = true;
		}

		if(other.gameObject.tag == "Enemy"){
			GameObject effectObj = Instantiate(destroyObstacleObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "CoinPlus"){
			addCoin();
    		Destroy(other.gameObject);
		}
	}

	void addCoin(){
		GameObject.Find("GameManager").GetComponent<CoinManager>().AddCoins(1);
	}
	

}
