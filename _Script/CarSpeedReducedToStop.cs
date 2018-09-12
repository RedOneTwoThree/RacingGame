using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class CarSpeedReducedToStop : MonoBehaviour {

	public GameObject myCar; 

	// Use this for initialization
	void Start () {
		myCar.GetComponent<CarUserControl> ().enabled = false;
		myCar.GetComponent<CarAIControl> ().enabled =true;
	

	}
	
	// Update is called once per frame
	void Update () {


}
}