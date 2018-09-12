using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTracker: MonoBehaviour {

	public GameObject Tracker;
	public GameObject Marker; 
	public Transform[] MarkerList;
	public int MarkTracker; 
	public GameObject MyCar;
	public Vector3 position;
	public Quaternion rotation; 
	public bool isSet=false;
	public GameObject wrongWayUI;

	// Use this for initialization
	void Start () {
		MarkerList = Marker.GetComponentsInChildren<Transform>();

	}


	
	// Update is called once per frame
	void Update () {
		if (isSet) {
			if(Input.GetKeyDown(KeyCode.R)){
				MyCar.transform.position = position;
				MyCar.transform.rotation = rotation;
				MyCar.transform.localEulerAngles = new Vector3 (MyCar.transform.localEulerAngles.x, MyCar.transform.localEulerAngles.y - 90f,MyCar.transform.localEulerAngles.z);

			}
		}

		WrongWay ();



		
	}
	void OnTriggerEnter(Collider collision){
		if (collision.tag == "Player") {
			
			if (MarkTracker == 33) {
				MarkTracker = 1;
				position = Tracker.transform.position;
				rotation = Tracker.transform.rotation;
				isSet = true;
				Tracker.transform.position = MarkerList [MarkTracker].position;
				Tracker.transform.rotation = MarkerList [MarkTracker].rotation;
			} else {
				MarkTracker += 1;				
				position = Tracker.transform.position;
				rotation = Tracker.transform.rotation;
				isSet = true;
				Tracker.transform.position = MarkerList [MarkTracker].position;
				Tracker.transform.rotation = MarkerList [MarkTracker].rotation;
				}
			}
	
	}


	public void WrongWay(){
		Vector3 directionToTarget = Tracker.transform.position - MyCar.transform.position;
		int angleToTarget = Mathf.CeilToInt(Mathf.Abs(Vector3.Angle(directionToTarget,MyCar.transform.forward)));


		if (angleToTarget > 90) {

			wrongWayUI.SetActive (true);

		} else {

			wrongWayUI.SetActive (false);
		
		}
	}
}
