using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

	public Text first;
	public Text second;
	public Text third;
	public Text forth;
	public Text fifth;
	public Text roku;
	public Text nana;
	public Text hachi;
	public Text kyu;
	public Text ju;
	public Text ju1;
	public Text ju2;
	private int t_flag = 0;
	private float f_flag = 0;
	public GameObject Back;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (f_flag == 0) {
			if (Input.GetMouseButtonDown (0)) {
				Debug.Log ("おしたよ");
				t_flag += 1;
				f_flag = 2;
			}
		}
		switch(t_flag) {
		case 0:
			break;
		case 1:
			if (f_flag >= 0) {
				first.color = new Color (255, 255, 255, f_flag);
				second.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;

			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 2:	
			if (f_flag >= 0) {
				second.color = new Color (255, 255, 255, f_flag);
				third.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 3:
			if (f_flag >= 0) {
				third.color = new Color (255, 255, 255, f_flag);
				forth.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 4:
			if (f_flag >= 0) {
				forth.color = new Color (255, 255, 255, f_flag);
				fifth.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;

		case 5:
			if (f_flag >= 0) {
				fifth.color = new Color (255, 255, 255, f_flag);
				roku.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 6:
			if (f_flag >= 0) {
				roku.color = new Color (255, 255, 255, f_flag);
				nana.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 7:
			if (f_flag >= 0) {
				nana.color = new Color (255, 255, 255, f_flag);
				hachi.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 8:
			if (f_flag >= 0) {
				hachi.color = new Color (255, 255, 255, f_flag);
				kyu.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 9:
			if (f_flag >= 0) {
				kyu.color = new Color (255, 255, 255, f_flag);
				ju.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 10:
			if (f_flag >= 0) {
				ju.color = new Color (255, 255, 255, f_flag);
				ju1.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 11:
			if (f_flag >= 0) {
				ju1.color = new Color (255, 255, 255, f_flag);
				ju2.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
	}
}
}
