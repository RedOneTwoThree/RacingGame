using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTriggerAI : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject RaceFinishTrigger;

	private int laps = 1; 

	void OnTriggerEnter(Collider collision){		


		if (collision.tag == "AICar01" ) {

			HalfLapTrig.SetActive (true);
			LapCompleteTrig.SetActive (false);
			if (laps < 2) {
				laps += 1;
				Debug.Log ("Lap count for AI = " + laps);
			} else {

				RaceFinishTrigger.SetActive (true);
				Debug.Log ("AI finish trigger has been activated");
			}	
		}
			

	}

}