using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (CheckScript.a_flag == 1) {
			gameObject.SetActive (true);
		} else if (CheckScript.a_flag == 0) {
			gameObject.SetActive (false);
		}
	}
}
