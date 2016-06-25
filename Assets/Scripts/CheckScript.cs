using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour {

	public static int flag = 0;
	public Text WallCheck;

	// Use this for initialization
	void Start () {
		WallCheck.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag ("Check")) {
			Debug.Log ("test");
			flag++;
			Destroy (other.gameObject);
		}
	}

	void OnCollisionStay(Collision other) {
		if (other.gameObject.CompareTag("Walls")) {
			WallCheck.text = "これ以上進めません！";

		}
	}
	void OnCollisionExit(Collision other){
		WallCheck.text = "";
	}
}