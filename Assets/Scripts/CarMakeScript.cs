using UnityEngine;
using System.Collections;

public class CarMakeScript : MonoBehaviour {

	public GameObject car;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Generate", 0, 5);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generate(){
		Instantiate (car, transform.position, transform.rotation);
		Invoke("DestroyCar", 18);
}

	void DestroyCar(){
		Destroy (this.gameObject);
	}
}