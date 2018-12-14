using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

	public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
	public GameObject spawner5;
	public GameObject spawner6;
	public GameObject spawner7;

	public TextMeshProUGUI currentScoreText;
	public TextMeshProUGUI bestScoreText;
	int currentScore = 0;

	void Start()
	{
		GetBestScore();
	}

	void GetBestScore(){
		bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
	}


	public void AddScore(int score){
		currentScore += score;
		currentScoreText.text = currentScore.ToString();

		if (currentScore > PlayerPrefs.GetInt("BestScore", 0))
		{
			bestScoreText.text = currentScore.ToString();
			PlayerPrefs.SetInt("BestScore", currentScore);
		}

		// if(currentScore == 1){
		// spawner1.SetActive(true);
		// }
		// if(currentScore == 2){
		// 	spawner2.SetActive(true);
		// }
		// if(currentScore == 3){
		// 	spawner3.SetActive(true);
		// }
		// if(currentScore == 5){
		// 	spawner5.SetActive(true);
		// }
		// if(currentScore == 6){
		// 	spawner6.SetActive(true);
		// }
		// if(currentScore == 7){
		// 	spawner7.SetActive(true);
		// }
	}
}
