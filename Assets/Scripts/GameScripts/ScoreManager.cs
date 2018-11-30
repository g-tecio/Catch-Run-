using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

	public TextMeshProUGUI currentScoreText;
	int currentScore = 0;


	public void AddScore(int score){
		currentScore += score;
		currentScoreText.text = currentScore.ToString();
	}
}
