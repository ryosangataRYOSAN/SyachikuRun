﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//SceneManager.LoadScene ("MainGame");
		}
	}

	public void ButtonPush(){
		Debug.Log ("おしたよ");
		SceneManager.LoadScene ("MainGame");
	}

}
