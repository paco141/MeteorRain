using UnityEngine;
using System.Collections;

public class laserTank : MonoBehaviour {
	click target;
	bool canFire = false;
	float timer;
	// Use this for initialization
	void Start () {
		target = FindObjectOfType<click>();
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(target.meteor());
		transform.LookAt( target.meteor().transform.position) ;
		timer+= Time.deltaTime;
		if (timer >  1f)
		{
			canFire =true;
		}

		if(canFire)
		{
			if(target.meteor().gameObject !=null)
			{
				Destroy(target.meteor().gameObject);
				timer = 0;
				canFire = false;
			}
		}

		//
		//charge up shot
		//	change it up so it fine as a lerp for visual effect
		// fires closet target
		//moves with pace with cam
		//Plane?

	}


}
