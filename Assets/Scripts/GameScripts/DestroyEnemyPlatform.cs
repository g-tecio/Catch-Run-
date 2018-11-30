﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyPlatform : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
    	{
    		GameObject effectObj = Instantiate(destroyObstacleObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
    	}
	}
}
