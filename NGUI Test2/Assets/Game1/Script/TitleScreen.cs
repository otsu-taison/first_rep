using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
		//Debug.Log("Title Scene loaded");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			
			//Debug.Log("mouse clicked at Title Scene");
			Application.LoadLevel("Game1");
		}	
	}
	
	void OnGUI(){
	
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		
		GUI.Label(new Rect(0, -100, sw, sh), " 射 的 で ド ン ！ ", "message");
		GUI.Label(new Rect(0, 80, sw, sh / 2), "Click to Start ", "message");
	}
}
