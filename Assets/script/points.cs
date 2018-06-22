using UnityEngine;
using System.Collections;

public class points : MonoBehaviour {
	public bool b_car;
	public bool b_person;
	public bool b_house;



	void OnCollisionEnter(Collision collision) {
	
		if(b_car== true && collision.gameObject.tag=="Meteor"){
		global.score+= 30;
			Destroy(gameObject);
		}

		if(b_person== true && collision.gameObject.tag=="Meteor"){
			global.score+= 20;
			Destroy(gameObject);
		}
	
		if (b_house==true && collision.gameObject.tag=="Meteor"){
			global.score+=10;
			Destroy(gameObject);
		}

				

	}
}
