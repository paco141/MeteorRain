using UnityEngine;
using System.Collections;

public class meteor : MonoBehaviour {

	public float radius = 5000.0F;
	public float power = 50000.0F;
	public GameObject expo;
	bool explode= false;


	void Update() {
		if(explode==true){
		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders) {
			if (hit && hit.rigidbody)
				hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F, ForceMode.Impulse);
			
		}
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter(Collision collision) {
		GameObject clone;
		if (collision.gameObject.tag =="Rocket")
		{

			Destroy(collision.gameObject);
		}
		clone = Instantiate(expo, transform.position, transform.rotation) as GameObject;
		explode=true;

	}
}
