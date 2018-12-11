using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

	private static DontDestroyAudio instance = null;
	public static DontDestroyAudio Instance
	{
		get {return instance;}
	}

	void Awake()
	{

		if(instance != null && instance != this){
			Destroy(this.gameObject);
		}
		else
		{
			instance = this;
		}
		// GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
		// if(objs.Length > 1){
		// 	Destroy(this.gameObject);
		// }
		// DontDestroyOnLoad(transform.gameObject);
		DontDestroyOnLoad(this.gameObject);
	}
}
