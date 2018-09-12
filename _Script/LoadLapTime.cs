using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LoadLapTime : MonoBehaviour {

	public string MilliDisplay;
	public string SecondDisplay;
	public string MiniuteDisplay;
	public static float timer;
	public GameObject BestLap;


	// Use this for initialization
	void Start () {
		timer = PlayerPrefs.GetFloat ("timer");
		if (timer == 0) {

			BestLap.GetComponent<Text>().text = "WR Lap: 00:00.0";
		
		
		} else {
				MilliDisplay = PlayerPrefs.GetString ("milli");
				SecondDisplay = PlayerPrefs.GetString ("sec");
				MiniuteDisplay = PlayerPrefs.GetString ("min");	

				BestLap.GetComponent<Text> ().text = "WR Lap: " + MiniuteDisplay + SecondDisplay + MilliDisplay;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
