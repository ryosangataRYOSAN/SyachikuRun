using UnityEngine;
using System.Collections;

public class CarMakeScript : MonoBehaviour {

	public GameObject car1;
	public GameObject car2;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Generate1", 0, 5);
		InvokeRepeating ("Generate2", 2.5f, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generate1(){
		Instantiate (car1, transform.position, transform.rotation);
		Invoke("DestroyCar", 18);
}

	void Generate2(){
		Instantiate (car2, transform.position, transform.rotation);
		Invoke("DestroyCar", 20);
	}

	void DestroyCar(){
		Destroy (this.gameObject);
	}
}