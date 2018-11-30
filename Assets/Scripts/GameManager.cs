using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject gameOverPanel;

	void Awake()
	{
		Time.timeScale = 1.0f;
	}

	public void GameOver(){
		StartCoroutine(gameOverCoroutine());
		GameObject.Find("Spawner1").GetComponent<RandomSpawn>().enabled = false;
		GameObject.Find("Spawner2").GetComponent<RandomSpawn>().enabled = false;
		GameObject.Find("Spawner3").GetComponent<RandomSpawn>().enabled = false;
		GameObject.Find("Spawner4").GetComponent<RandomSpawn>().enabled = false;
		GameObject.Find("Spawner5").GetComponent<RandomSpawn>().enabled = false;
	}

	IEnumerator gameOverCoroutine(){
		yield return new WaitForSecondsRealtime(0.1f);
		Time.timeScale = 0.1f;
		yield return new WaitForSecondsRealtime(0.1f);
		GetComponent<ScoreManager>().currentScoreText.color = Color.white;
		gameOverPanel.SetActive(true);
		
		yield break;
	}

	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
