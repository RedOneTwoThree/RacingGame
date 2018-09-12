using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MasterAudio : MonoBehaviour {


	public AudioMixer audioMixer;
	private float dB;

	void Start(){

	
	}

	public void SetVolume(float volume){

		if (volume != 0) {
			dB = 20.0f * Mathf.Log10 (volume);
		} else {
			dB = -80.0f;
		}

		audioMixer.SetFloat ("Volume", dB );
		
	}



}
