using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {

	public Rigidbody test;
	Vector3 targetPoint;
	Rigidbody clone;
	float timer;
	public float fireRate;
	bool canFire = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!canFire)
		timer+= Time.deltaTime;

		if (timer> fireRate)
		{

			canFire = true;
		}

		if (Input.GetButtonDown("Fire1") && canFire) {


			RaycastHit vHit = new RaycastHit();
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray,out vHit, 100)){
			
				targetPoint= vHit.point;

				
			}
			transform.LookAt(targetPoint);

			clone = Instantiate(test, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 15);
			canFire = false;
			timer =0;
		
		}




	}

	public Rigidbody meteor()
	{

		return clone;
	}
}
