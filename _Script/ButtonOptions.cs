using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {
	private AudioSource[] allAudio;
	public static int carType; //1=red 2=blue 3=green 4=yellow
	public static int AICarType; 
	public GameObject loadingImage;
	public static bool timeTrial = false;  


	public void CarSelect1(){
		carType = 1;
		int[] leftover = new int[] {2, 3, 4}; 
		AICarType = leftover [Random.Range (0, 3)];
		loadingImage.SetActive (true);
		SceneManager.LoadScene (1);

	}

	public void CarSelect2(){
		carType = 2;
		int[] leftover = new int[] {1, 3, 4}; 
		AICarType = leftover[Random.Range(0,2)];
		loadingImage.SetActive (true);
		SceneManager.LoadScene (1);
	}
	public void CarSelect3(){
		carType = 3;
		int[] leftover = new int[] {1, 2, 4}; 
		AICarType = leftover[Random.Range(0,2)];
		loadingImage.SetActive (true);
		SceneManager.LoadScene (1);

	}
	public void CarSelect4(){
		carType = 4;
		int[] leftover = new int[] {1, 2, 3}; 
		AICarType = leftover[Random.Range(0,2)];
		loadingImage.SetActive (true);
		SceneManager.LoadScene (1);
	}

	public void CarSelect1T(){
		carType = 1;
		timeTrial = true;
		loadingImage.SetActive (true);
		SceneManager.LoadScene (2);
	}
	public void CarSelect2T(){
		carType = 2;
		timeTrial = true;
		loadingImage.SetActive (true);
		SceneManager.LoadScene (2);
	}
	public void CarSelect3T(){
		carType = 3;
		timeTrial = true;
		loadingImage.SetActive (true);
		SceneManager.LoadScene (2);
	}
	public void CarSelect4T(){
		carType = 4;
		timeTrial = true;
		loadingImage.SetActive (true);
		SceneManager.LoadScene (2);
	}

	public void Quit(){
		Application.Quit ();
	}


}
