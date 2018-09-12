using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarStart: MonoBehaviour {

	public GameObject Car;
	public GameObject AICar;


	// Use this for initialization
	void Start () {
		
		Car.GetComponent<CarUserControl> ().enabled = true;
		AICar.GetComponent<CarAIControl> ().enabled = true; 

	}


}
