using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour {

	public void reset(){

		PlayerPrefs.SetFloat ("timer", 0);
		PlayerPrefs.SetString ("milli", "0");
		PlayerPrefs.SetString ("sec", "00.");
		PlayerPrefs.SetString ("min", "00:");
	}
}
