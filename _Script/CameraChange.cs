using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

	public GameObject normalCamera; 
	public GameObject farCamera;
	public GameObject FPCamera;
	public int mode; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Viewmode")){
			if (mode == 2) {
				mode = 0;
			
			} else {
				mode += 1;
			}
			StartCoroutine (ModeChange ());
		}
	}
	IEnumerator ModeChange(){
		yield return new WaitForSeconds (0.01f);
		if (mode == 0) {
			normalCamera.SetActive (true);
			FPCamera.SetActive (false);
		}
		if (mode == 1) {
			farCamera.SetActive (true);
			normalCamera.SetActive (false);
		}
		if (mode == 2){
			FPCamera.SetActive (true);
			farCamera.SetActive (false);
		}
	}

}
