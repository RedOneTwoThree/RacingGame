using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour {

	// Use this for initialization
	public Transform water;
	public float defaultX; 

	void Start () {
		water = this.GetComponent<Transform> ();
		defaultX = water.position.x ;
	}

	// Update is called once per frame
	void Update () {
		if (this.GetComponent<Transform> ().position.x < defaultX) {
			WaterMove (0.1f);
			
		} else {
			WaterMove (-0.1f);
		}

	}

	void WaterMove(float n){
		water.position = new Vector3 (water.position.x + n, water.position.y ,water.position.z);

	}
}
