using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {
	public bool timeCar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position +=  gameObject.transform.forward *( 5*Time.deltaTime);
	}

	void OnCollisionEnter(Collision collision) {
		if (timeCar == true) {
			global.StartTime+= 10.0f;
				}
		}
}
