using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class RaceFinishAI : MonoBehaviour {

	public GameObject MyCar;
	public GameObject AICar;
	public GameObject ReducedToStop;
	public GameObject CompleteTrig;
	public GameObject ViewCam; 
	public GameObject FinishCam;
	public GameObject LevelMusic; 
	public AudioSource FinishMusic; 
	private AudioSource[] allAudio; 
	public GameObject clearUI;
	public GameObject LoseMenu;


	void Start(){
		allAudio = FindObjectsOfType <AudioSource>();

	}

	void OnTriggerEnter(Collider collision){
		if (collision.tag == "AICar01") {
		//	ReducedToStop.SetActive (true);
			Destroy (AICar);
			this.GetComponent<BoxCollider>().enabled =false; 
			MyCar.SetActive(false);
			MyCar.transform.position = new Vector3 (334f, 3f, 155.34f);
			MyCar.transform.rotation = new Quaternion (0f,-243.2f,0f,1f);


			MyCar.GetComponent<CarController> ().enabled = false;
			MyCar.GetComponent<CarUserControl>().enabled = false;
			MyCar.SetActive (true);
			CompleteTrig.SetActive (false);
			FinishCam.SetActive (true);
			ViewCam.SetActive (false);
			foreach(AudioSource i in allAudio){
				i.Stop ();
			}
			FinishMusic.Play ();
			LevelMusic.SetActive (false);
			clearUI.SetActive (false);

			LoseMenu.SetActive (true);

		}
			

	}
		




}