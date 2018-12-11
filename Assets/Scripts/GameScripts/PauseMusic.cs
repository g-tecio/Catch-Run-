using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMusic : MonoBehaviour {

	
	void Start () {
		DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
	}
}
