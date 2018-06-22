using UnityEngine;
using System.Collections;

public class DESTROYER : MonoBehaviour {

	void OnCollisionEnter(Collision trash)
	{
		Debug.Log("WHAT");
		Destroy(trash.gameObject);

	}
}
