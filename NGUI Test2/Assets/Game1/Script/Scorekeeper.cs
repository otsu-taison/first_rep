using UnityEngine;
using System.Collections;
[HideInInspector]

public class Scorekeeper : MonoBehaviour {

	public int score;
	string scoreText;
	
	public GUISkin skin;
	
	void Start () {
	
	}
	
	void Update () {
	
	}
	
	void OnGUI(){
	
		GUI.skin = skin;
		
		int sw = Screen.width;
		int sh = Screen.height;
		if(score <= 0){
		scoreText = "SCORE: ";
		}
		else{
		scoreText = "SCORE: " + score.ToString();			
		}
		GUI.Label(new Rect(0, 0, sw / 2, sh / 4), scoreText, "score");
	}
}
