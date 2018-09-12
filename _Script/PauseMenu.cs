using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	private AudioSource[] allAudio;
	public GameObject timeTrialComplete; 

	void Start(){
		allAudio = FindObjectsOfType <AudioSource>();
	}
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
			if (GameIsPaused) {
				Resume ();

			} else {
				Pause ();
			}
		}
		
	}

	public void Resume(){
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;

		foreach(AudioSource i in allAudio){
			i.UnPause ();
		}
		
	}

	void Pause(){
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;

		foreach(AudioSource i in allAudio){
			i.Pause ();
		}

	}

	public void Retry(){
		Time.timeScale = 1f;
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.timer = 0;
		SceneManager.LoadScene (1);

	}

	public void ReurnToMenu(){
		Time.timeScale = 1f;
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.timer = 0;
		SceneManager.LoadScene (0);
		ButtonOptions.timeTrial = false; 

	}

	public void EndTimeTrial(){
		Time.timeScale = 1f;
		pauseMenuUI.SetActive (false);
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.timer = 0;
		timeTrialComplete.SetActive (true);


	}
}
