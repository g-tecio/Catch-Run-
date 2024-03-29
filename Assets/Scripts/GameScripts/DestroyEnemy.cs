﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyEnemy : MonoBehaviour {

	public GameObject DeathEffectObj;

	GameObject[] gameObjects; 

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
    	{
    		GameObject effectObj = Instantiate(DeathEffectObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
			GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
			GameObject buttons = GameObject.Find("Buttons");
			buttons.SetActive(false);
    	}

		if(other.gameObject.tag == "Platform"){
			GameObject effectObj = Instantiate(DeathEffectObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
		}
	}


	 void DestroyAllObjects()
 	{
      	gameObjects = GameObject.FindGameObjectsWithTag ("Enemy");
     
		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
		}
 	}
}
