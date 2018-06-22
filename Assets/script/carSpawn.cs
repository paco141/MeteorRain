using UnityEngine;
using System.Collections;

public class carSpawn : MonoBehaviour {
	public GameObject[] car;
	float spawnTime = 2.0f ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawnTime  -= Time.deltaTime ;

		if(spawnTime<= 0.0f){
		GameObject clone;
		clone = Instantiate(car[0], transform.position, transform.rotation) as GameObject;
		
		if (LightPost.lightHit== true){
				GameObject clone2;
				clone2 = Instantiate(car[1], transform.position, transform.rotation) as GameObject;
				LightPost.lightHit = false;
		}
		

			spawnTime = Random.Range(2,6);
		}


	}

}
