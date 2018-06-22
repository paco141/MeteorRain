using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class hpBar : MonoBehaviour {

	RectTransform bar;
	public float hp;
	float maxHP;
	float barLerp;
	float barLength;
	Vector2 barVector;
	// Use this for initialization
	void Start () {
		bar = gameObject.GetComponent<RectTransform>();
		maxHP = hp;
	}
	
	// Update is called once per frame
	void Update () {
	
		
		barLerp= hp/maxHP;
		barLength = Mathf.Lerp(0,100, barLerp);
		barVector = new Vector2 (barLength,bar.sizeDelta.y);
		bar.sizeDelta = barVector;
	}
}
