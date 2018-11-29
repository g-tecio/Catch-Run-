using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	public GameObject prefab1, prefab2, prefab3;

	public float spawnRate = 2f;

	float nextSpawn = 1f;

	int whatToSpawn;
	
	void Update () {
		if (Time.time > nextSpawn)
		{
			whatToSpawn = Random.Range(1, 6);

			switch (whatToSpawn)
			{
				case 1: 
					Instantiate(prefab1, transform.position, Quaternion.identity);
					break;
				case 2: 
					Instantiate(prefab2, transform.position, Quaternion.identity);
					break;
				case 3: 
					Instantiate(prefab3, transform.position, Quaternion.identity);
					break;
			}
			nextSpawn = Time.time + spawnRate; 
		}
	}
}
