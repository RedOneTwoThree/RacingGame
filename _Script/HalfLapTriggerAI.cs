using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTriggerAI : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;


	void OnTriggerEnter(Collider collision){
		if(collision.tag == "AICar01"){
		LapCompleteTrig.SetActive (true);
		HalfLapTrig.SetActive (false);
		}
	}


}
