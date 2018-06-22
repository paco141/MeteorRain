using UnityEngine;
using System.Collections;

public class LightPost : MonoBehaviour {
	public Light LightG;
	public Light LightR;
	public GameObject carTime;
	public static bool lightHit;

	// Use this for initialization
	void Start () {
		LightG.intensity = 0;
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter(){
		lightHit =true;
		Destroy (gameObject);
		//collider.enabled= false;

	}
}
