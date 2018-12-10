using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour {

	public TextMeshProUGUI currentCoinText;
	public TextMeshProUGUI bestCoinText;
	int currentScore = 0;

	void Start()
	{
		GetBestCoins();
	}

	void GetBestCoins(){
		bestCoinText.text = PlayerPrefs.GetInt("TotalCoins", 0).ToString();
	}


	public void AddCoins(int score){
		currentScore += score;
		currentCoinText.text = currentScore.ToString();

		if (currentScore > PlayerPrefs.GetInt("TotalCoins", 0))
		{
			bestCoinText.text = currentScore.ToString();
			PlayerPrefs.SetInt("TotalCoins", currentScore);
		}
	}
}
