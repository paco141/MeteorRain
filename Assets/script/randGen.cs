using UnityEngine;
using System.Collections;

public class randGen : MonoBehaviour {
	public GameObject[] groups;
	public Transform  startPos;
	
	public GameObject cam;

	int randomSelect;
	float dist;
	float timeLeft;

	// Use this for initialization
	void Start () {
		//groups = new GameObject[1];
		timeLeft = global.StartTime;
		timeLeft -= 10;
	

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ("timeleft" + timeLeft);
		//if(global.StartTime <= timeLight){
		
		//	randomSelect = 3;
		//}
		//else{
			randomSelect = Random.Range(0,3);
		//}


		if(global.gameDone== false){
			float dist = Vector3.Distance(cam.transform.position, startPos.position);
			if( dist<= 50.0f){ 

				GameObject clone;
				clone = Instantiate(groups[randomSelect], startPos.position , startPos.rotation) as GameObject;
				startPos.position = new Vector3(startPos.position.x, startPos.position.y, (startPos.position.z+10.0f) );
			}
			//Debug.Log("dist" +dist);


		}
	
	}
}
