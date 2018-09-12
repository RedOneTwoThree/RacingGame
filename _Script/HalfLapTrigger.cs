using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;


	void OnTriggerEnter(Collider collision){
		if(collision.tag == "Player"){
		LapCompleteTrig.SetActive (true);
		HalfLapTrig.SetActive (false);
		}
	}


}
