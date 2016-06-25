using UnityEngine;
using System.Collections;

public class CheckScript : MonoBehaviour {

	public static int flag = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag("Check")) {
			Debug.Log ("test");
			flag++;
			Destroy(other.gameObject);
		}
}
}