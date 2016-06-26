using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	public Text time;
	public static float timeLimit = 30.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLimit -= Time.deltaTime;
		if (timeLimit >= 10) {
			time.text = " Time : " + timeLimit.ToString ("f2") + " ";
		}
		if (timeLimit <= 10) {
			time.color = Color.red;
			time.text = " Time : 0" + timeLimit.ToString ("f2") + " ";
		}

		if (timeLimit <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
