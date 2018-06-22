using UnityEngine;
using System.Collections;

public class global : MonoBehaviour {
	public static int score=0;
	public static float StartTime=50;
	public static bool gameDone = false;
	string TextTime;
	hpBar bar;

	
	
	// Use this for initialization
	void Start () {
	
		bar = FindObjectOfType<hpBar>();
	}
	
	// Update is called once per frame20
	void Update(){
		
		StartTime  -= Time.deltaTime ;
		TextTime= string.Format("{0:00}",StartTime);
		if(bar.hp <= 0.0f){
			gameDone =true;
			Time.timeScale = 0;
		}
		
		
		
	}

	void OnGUI() {
		GUI.Box(new Rect(10, 10, 100, 20), "score: "+score);
		//GUI.Box (new Rect (10, 30, 100, 20), "Time" + TextTime);
		if(gameDone==true){
		if (GUI.Button (new Rect (200, 200, 150, 100), "resart game") ) {
				
				StartTime = 50;
				score = 0;
				Time.timeScale = 1;
                gameDone = false;
			Application.LoadLevel ("testscene");
				 
			
		}
		}
	}

}
