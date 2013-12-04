using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

	public GUISkin skin;
	
	private float timer;
	
	public AudioClip countSE;
	
	void Start () {
	
		timer = 3.5f;
	}
	
	void Update () {
	
		timer -= Time.deltaTime;
		if(timer <= 0.0f){
			
			BroadcastMessage("StartGame");
			//Debug.Log("send the signal of StartGame method");
			
			
			
			GameObject.FindWithTag("MainCamera").SendMessage("StartGame");
			//Debug.Log("send the signal of StartGame method to Gun");
			
			GameObject.FindWithTag("GiftGenerator").SendMessage("StartGame");
			//Debug.Log("send the signal of StartGame method to GiftGenerator");
			enabled = false;
		}
	}
	
	void OnGUI(){
	
		if(timer > 3.0f || timer <= 0.0) return;
		
		
		int sw = Screen.width;
		int sh = Screen.height;
		string text = Mathf.CeilToInt(timer).ToString();
		GUI.skin = skin;
		GUI.color = new Color(1, 1, 1, timer - Mathf.FloorToInt(timer));
		GUI.Label(new Rect(0, sh / 4, sw, sh / 2), text, "message");
	}
}
