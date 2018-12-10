using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScreenControl : MonoBehaviour {

	public GameObject loadScreenObj;
	public GameObject buttonStart;
	public Slider slider;
	public TextMeshProUGUI progressText;
	

	public void LoadScreen(int sceneIndex){
		StartCoroutine(LoadingScreen(sceneIndex));
	}

	IEnumerator LoadingScreen(int sceneIndex){
		
		AsyncOperation async = SceneManager.LoadSceneAsync(sceneIndex);
		buttonStart.SetActive(false);
		loadScreenObj.SetActive(true);
		while (!async.isDone)
		{
			float progress = Mathf.Clamp01(async.progress / .9f);
			slider.value = progress;
			progressText.text = progress * 100f + "%";

			yield return null;
		}


	}
}
