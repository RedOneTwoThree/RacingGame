using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount = 0;
	public static int SecondCount = 0;
	public static float MilliCount = 0f;
	public static float timer = 0f;
	public static string MilliDisplay;
	public static string SecondDisplay;
	public static string MiniuteDisplay;



	public GameObject LapTime; 
	public string LapTimeString; 


	void Update () {

		timer += Time.deltaTime;
		MilliCount += (Time.deltaTime * 10);
		if(MilliCount < 9){
			MilliDisplay = MilliCount.ToString ("F0");
		}
		if (MilliCount > 10) {
			MilliCount = 0;
			SecondCount += 1;
		}

		if (SecondCount < 10) {
			SecondDisplay = "0" + SecondCount.ToString() + ".";
		} else {
			SecondDisplay = "" + SecondCount + ".";
		}

		if (SecondCount >= 59) {
			SecondCount = 0;
			MinuteCount += 1;
		}

		if (MinuteCount <= 9) {
			MiniuteDisplay = "0" + MinuteCount + ":";
		} else {
			MiniuteDisplay = "" + MinuteCount + ":";
		}

		LapTime.GetComponent<Text> ().text ="Lap Time: " + MiniuteDisplay + SecondDisplay + MilliDisplay;


	}
}

