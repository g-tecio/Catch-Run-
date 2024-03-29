﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour {

	public GameObject destroyObstacleObj;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
    	{
			addScore();
    		GameObject effectObj = Instantiate(destroyObstacleObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
    	}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "CoinPlus")
    	{
    		Destroy(other.gameObject);
    	}
	}

	void addScore(){
		GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore(1);
	}
}
