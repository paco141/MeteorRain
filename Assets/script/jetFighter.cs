using UnityEngine;
using System.Collections;

public class jetFighter : MonoBehaviour {
	public GameObject projectile;
	public float speed;
	bool test =false;
	click target;
	public float range;
	public float fireRate;
	float timer;
	GameObject clone;
	Vector3 orgin;
	public float length = 2;
	public float moveSpeed = 2.8f;
	public float signRate = 2.8f;
	public float HP=2;
	//GameObject targPos;
	//GameObject rocketClone;
	void Start () {
		orgin = transform.position;
		target = FindObjectOfType<click>();
		
	}

	void Update(){
		float dist = Vector3.Distance(transform.position, target.transform.position);
		if (range >= dist)
		{
			timer += Time.deltaTime;
			if (fireRate <= timer){
				float step = speed * Time.deltaTime;
				//spwan rocket

				clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
				timer =0;
			}

		}
		Move();
		health();
		// move rocket
		/*

		clone.transform.LookAt (other.gameObject.transform.position);
		clone.transform.position = Vector3.MoveTowards(clone.transform.position, other.gameObject.transform.position, step);
		*/
		//Debug.LogWarning ("traget:" + targPos.transform.position);
		//rocketClone.transform.LookAt (targPos.transform.position);
		//rocketClone.transform.position = Vector3.MoveTowards (rocketClone.transform.position, targPos.transform.position, step);
	}

	void Move()
	{
		float wave = Mathf.Sin (Time.time * signRate) * length ;
		transform.position = new Vector3(wave + orgin.x,transform.position.y, Time.deltaTime*moveSpeed+transform.position.z );

	}
	void OnCollisionEnter(Collision meteor){
		if (meteor.gameObject.tag == "Meteor")
		{
			HP-=1;
		}
	}
	void health()
	{
		if (HP == 0)
		{
			Destroy(gameObject);
		}
	}

}
