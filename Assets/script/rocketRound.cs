using UnityEngine;
using System.Collections;

public class rocketRound : MonoBehaviour {
	click target;
	public float speed =10;
	hpBar bar;

	// Use this for initialization
	void Start () {
		target = FindObjectOfType<click>();
		bar = FindObjectOfType<hpBar>();
	}


	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
		float dist = Vector3.Distance(transform.position,target.transform.position);
		if( .2f >= dist)
		{
			bar.hp-= 10;
			Destroy(this.gameObject);
		}
	}

}
