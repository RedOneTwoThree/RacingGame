using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColour : MonoBehaviour {

	public GameObject Car; 
	public GameObject AICar;
	public Material red;
	public Material blue;
	public Material green;
	public Material yellow;  

	// Use this for initialization
	void Start () {
		if (ButtonOptions.carType == 1) {
			Car.GetComponent<MeshRenderer> ().material = red;
		}
		if (ButtonOptions.carType == 2) {
			Car.GetComponent<MeshRenderer> ().material = blue;
		}		
		if (ButtonOptions.carType == 3) {
			Car.GetComponent<MeshRenderer> ().material = green;
		}
		if (ButtonOptions.carType == 4) {
			Car.GetComponent<MeshRenderer> ().material = yellow;
		}
		if (ButtonOptions.AICarType == 1) {
			AICar.GetComponent<MeshRenderer> ().material = red;
		}
		if (ButtonOptions.AICarType == 2) {
			AICar.GetComponent<MeshRenderer> ().material = blue;
		}
		if (ButtonOptions.AICarType == 3) {
			AICar.GetComponent<MeshRenderer> ().material = green;
		}
		if (ButtonOptions.AICarType == 4) {
			AICar.GetComponent<MeshRenderer> ().material = yellow;
		}

	}

}
