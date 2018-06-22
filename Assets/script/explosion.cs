using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public float StartTime;
	public float Timer=1.0f;
	// Use this for initialization
	void Start () {
		StartTime = Time.time;
		
	}
	void Update(){
		if((Time.time - StartTime)> Timer){
			Destroy(gameObject);

		}

	}
}
