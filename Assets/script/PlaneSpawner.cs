using UnityEngine;
using System.Collections;

public class PlaneSpawner : MonoBehaviour {

	public GameObject plane;
	public float spawnTimerMax;
	public float spawNTimerMin;
	float timer = 0;
	float spawnTimer;
	// Use this for initialization
	void Start () {
	
		spawnTimer = Random.Range(spawNTimerMin,spawnTimerMax); 
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Debug.Log(spawnTimer);
		if(timer >= spawnTimer)
		{
			GameObject clone;
			clone = Instantiate(plane,this.transform.position,this.transform.rotation) as GameObject;
			timer = 0;
			clone.GetComponent<jetFighter>().signRate = Random.Range(0,2.5f);
			clone.GetComponent<jetFighter>().moveSpeed = Random.Range(2,5.5f);
			spawnTimer = Random.Range(spawNTimerMin,spawnTimerMax);
		}

	

	}


}
