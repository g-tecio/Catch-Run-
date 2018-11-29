using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour {

	public GameObject DeathEffectObj;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
    	{

    		GameObject effectObj = Instantiate(DeathEffectObj, other.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(other.gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	}
	}
}
