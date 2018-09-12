using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Countdown : MonoBehaviour {

	public GameObject countDown; 
	public AudioSource m_countdown;
	public GameObject lapTimer; 
	public GameObject carControls;
	public AudioSource m_RacingMusic;
	private AudioSource[] allAudio;

	// Use this for initialization
	void Start () {
		StartCoroutine (CountStart ());
		m_countdown.Play ();
	}

	IEnumerator CountStart (){
	//	yield return new WaitForSeconds (0.5f);
		allAudio = FindObjectsOfType <AudioSource>();
		foreach(AudioSource i in allAudio){
			i.Stop ();
		}
		countDown.GetComponent<Text>().text = "3";

		countDown.SetActive (true); 
		yield return new WaitForSeconds (1);
		countDown.SetActive (false);
		countDown.GetComponent<Text>().text = "2";
		countDown.SetActive (true);
		yield return new WaitForSeconds (1);
		countDown.SetActive (false);
		countDown.GetComponent<Text>().text = "1";
		countDown.SetActive (true);
		yield return new WaitForSeconds (1);
		countDown.SetActive (false);
		countDown.GetComponent<Text>().text = "Go!";
		countDown.SetActive (true);
		lapTimer.SetActive (true); 
		carControls.SetActive (true);
		yield return new WaitForSeconds (1);
		m_RacingMusic.Play ();

	
	}
}
