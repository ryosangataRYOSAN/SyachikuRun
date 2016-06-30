using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour {

	public static int flag = 0;
	public static int a_flag = 0;
	public static int score = 0;
	float a_color = 1.0f;
	public Text WallCheck;
	public Text PointCheck;
	public Text ScoreText;
	public GameObject panel;

	// Use this for initialization
	void Start () {
		ScoreText.text = "Score : " +   score.ToString ("");
		WallCheck.text = "";
		PointCheck.text = "Point : " + flag.ToString ("");
		PointCheck.color = new Color (0,0,0,0);
		panel.GetComponent<Image>().color = new Color (124/255f,234/255f,1,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (a_flag == 1) {
			PointCheck.color = new Color (0, 0, 0, a_color);
			a_color -= Time.deltaTime;
			if (a_color <= 0) {
				a_flag = 0;
				panel.GetComponent<Image>().color = new Color (124/255f,239/255f,1,0);
			}
		}
	}

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag ("Check")) {
			flag++;
			score += 500;
			a_flag = 1; 
			a_color = 1;
			Destroy (other.gameObject);
			PointCheck.color = new Color (0,0,0,1);
			panel.GetComponent<Image>().color = new Color (124/255f,239/255f,1,1);
			PointCheck.text = "Point : " + flag.ToString ("");
			ScoreText.text = "Score : " +   score.ToString ("");
		}

		if (other.gameObject.CompareTag ("Owabi")) {
			flag++;
			score += 500;
			a_flag = 1; 
			a_color = 1;
			Destroy (other.gameObject);
			PointCheck.color = new Color (0,0,0,1);
			panel.GetComponent<Image>().color = new Color (124/255f,239/255f,1,1);
			PointCheck.text = "お詫びの品を手に入れた";
			ScoreText.text = "Score : " +   score.ToString ("");
			}
	
		if (other.gameObject.CompareTag ("Shiryou")) {
			flag++;
			score += 500;
			a_flag = 1; 
			a_color = 1;
			Destroy (other.gameObject);
			PointCheck.color = new Color (0,0,0,1);
			panel.GetComponent<Image>().color = new Color (124/255f,239/255f,1,1);
			PointCheck.text = "改善案の書類を手に入れた";
			ScoreText.text = "Score : " +   score.ToString ("");
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