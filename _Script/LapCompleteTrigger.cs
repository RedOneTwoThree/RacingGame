using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject RaceFinishTrigger;
	public GameObject Timer;
	public static float currentBestTime = 0;
	public static string currentBestTimeString;




	public GameObject BestLap;
	public GameObject currentBest;

	public GameObject LapCount;
	public int laps = 1; 

	void Update(){
		
	}

	void OnTriggerEnter(Collider collision){
		if (collision.tag == "Player" ) {

			if (ButtonOptions.timeTrial == true) {
			
			} else {

				if (laps < 2) {
					laps += 1;
					LapCount.GetComponent<Text> ().text = "Lap: " + laps + "/2"; 
					Debug.Log ("Lap count for player = " + laps);

				} else {

					RaceFinishTrigger.SetActive (true);
					Timer.SetActive (false);
					Debug.Log ("player finish trigger has been activated");

				}
			}

			if(currentBestTime > LapTimeManager.timer || currentBestTime == 0f){
				currentBestTime = LapTimeManager.timer;
				currentBestTimeString = LapTimeManager.MiniuteDisplay + LapTimeManager.SecondDisplay + LapTimeManager.MilliDisplay;
				currentBest.GetComponent<Text>().text = "Current Best: " + currentBestTimeString;

			}

			if (LoadLapTime.timer > LapTimeManager.timer || LoadLapTime.timer == 0f) {

				BestLap.GetComponent<Text> ().text = "WR Lap: " + LapTimeManager.MiniuteDisplay + LapTimeManager.SecondDisplay + LapTimeManager.MilliDisplay;

				PlayerPrefs.SetFloat ("timer", LapTimeManager.timer);
				PlayerPrefs.SetString ("milli", LapTimeManager.MilliDisplay);
				PlayerPrefs.SetString ("sec", LapTimeManager.SecondDisplay);
				PlayerPrefs.SetString ("min", LapTimeManager.MiniuteDisplay);
			}




			LapTimeManager.MinuteCount = 0;
			LapTimeManager.SecondCount = 0;
			LapTimeManager.MilliCount = 0;
			LapTimeManager.timer = 0;


			HalfLapTrig.SetActive (true);
			LapCompleteTrig.SetActive (false);
		}

	}

}