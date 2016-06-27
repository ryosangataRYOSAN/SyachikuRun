using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour {

	public static int flag = 0;
	public Text WallCheck;
	public Text PointCheck;

	// Use this for initialization
	void Start () {
		WallCheck.text = "";
		PointCheck.text = "Point : " + flag.ToString ("");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag ("Check")) {
			flag++;
			Destroy (other.gameObject);
			PointCheck.text = "Point : " + flag.ToString ("");
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