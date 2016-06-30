using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	public Text ju3;
	public Text ju4;
	public GameObject ju5;
	public Text ju6;
	public Text ju7;
	public GameObject ju8;
	public Text ju9;
	public Text niju;
	public Text niju1;
	public Text niju2;
	public Text niju3;
	private int t_flag = 0;
	private float f_flag = 0;
	public GameObject Back;
	public Text Next;

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
		case 12:
			if (f_flag >= 0) {
				ju2.color = new Color (255, 255, 255, f_flag);
				ju3.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 13:
			if (f_flag >= 0) {
				ju3.color = new Color (255, 255, 255, f_flag);
				ju4.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 14:
			if (f_flag >= 0) {
				ju4.color = new Color (255, 255, 255, f_flag);
				ju5.GetComponent<Image>().color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 15:
			if (f_flag >= 0) {
				ju5.GetComponent<Image>().color = new Color (255, 255, 255, f_flag);
				ju6.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 16:
			if (f_flag >= 0) {
				ju6.color = new Color (255, 255, 255, f_flag);
				ju7.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 17:
			if (f_flag >= 0) {
				ju7.color = new Color (255, 255, 255, f_flag);
				ju8.GetComponent<Image>().color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 18:
			ju8.transform.localScale = new Vector3 (2, 2, 2);
			Invoke ("fgen", 1);
			break;
		case 19:
			ju8.transform.localScale = new Vector3 (4, 4, 4);
			Invoke ("fgen", 1);
			break;
		case 20:
			if (f_flag >= 0) {
				ju8.GetComponent<Image>().color = new Color (255, 255, 255, f_flag);
				ju9.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 21:
			if (f_flag >= 0) {
				ju9.color = new Color (255, 255, 255, f_flag);
				niju.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 22:
			if (f_flag >= 0) {
				niju.color = new Color (255, 255, 255, f_flag);
				niju1.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
			}
			break;
		case 23:
			if (f_flag >= 0) {
				niju1.color = new Color (255, 255, 255, f_flag);
				niju2.color = new Color (255, 255, 255, 1 - f_flag);
				f_flag -= 2 * Time.deltaTime;
			}
			if (f_flag <= 0) {
				f_flag = 0;
				Next.text = "画面クリックでゲームへ";
			}
			break;
		case 24:
			SceneManager.LoadScene ("MainGame");
			break;
	}
}

	public void fgen(){
		f_flag = 0;
	}

}
