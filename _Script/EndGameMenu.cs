using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndGameMenu : MonoBehaviour {

	public Text bestLapTime;
	public Text recordLapTime; 
	public string MilliDisplay;
	public string SecondDisplay;
	public string MiniuteDisplay;


	// Use this for initialization
	void Start () {

		Cursor.visible = true;

		MilliDisplay = PlayerPrefs.GetString ("milli");
		SecondDisplay = PlayerPrefs.GetString ("sec");
		MiniuteDisplay = PlayerPrefs.GetString ("min");	

		Debug.Log (MilliDisplay);

		recordLapTime.text = MiniuteDisplay + SecondDisplay + MilliDisplay;

		bestLapTime.text = LapCompleteTrigger.currentBestTimeString;

		
	}

	public void back(){

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.timer = 0;
		SceneManager.LoadScene (0);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
