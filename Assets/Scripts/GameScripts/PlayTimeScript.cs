using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTimeScript : MonoBehaviour {

	public int playTime = 0;
	private int seconds = 0;
	private int minutes = 0;
	private int hours = 0;
	private int days = 0;


	void Start () {
		StartCoroutine("PlayTimer");
	}

	IEnumerator PlayTimer(){

		while(true){
			yield return new WaitForSeconds(1);
			playTime += 1;
			seconds = (playTime % 60);
			minutes = (playTime / 60) % 60;
			hours = (playTime / 3600) % 24;
			days = (playTime / 86400) % 365;
		}

	}

	void OnGUI()
	{
		GUI.Label(new Rect(50, 50, 400, 50), "Played = " + days.ToString() + " Days " + hours.ToString() + " Hours " + minutes.ToString() + " Minutes " + seconds.ToString() + " Seconds ");
	}
	
}
