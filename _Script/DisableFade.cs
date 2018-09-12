using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableFade : MonoBehaviour {

	public GameObject fade;

	// Use this for initialization
	void Start () {

		StartCoroutine(disableFade());
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
	IEnumerator disableFade(){

		yield return new WaitForSeconds(1.0f);
		fade.SetActive (false);
	
	
	}
}
