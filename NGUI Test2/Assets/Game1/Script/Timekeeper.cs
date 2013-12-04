using UnityEngine;
using System.Collections;

public class Timekeeper : MonoBehaviour {
	
	public float gameLength;
	private float elapsed;
	
		public AudioClip battleBGM;
	
	void Start () {}
	
	void Update () {
	
		elapsed += Time.deltaTime;
		if(elapsed >= gameLength){
			
			audio.Stop();
			
			BroadcastMessage("TimeUp");
			GameObject.FindWithTag("MainCamera").SendMessage("TimeUp");
			StartCoroutine("ShowResult");
			enabled = false;
		}
	}

	IEnumerator ShowResult(){
	
		yield return new WaitForSeconds(10.5f);
		Application.LoadLevel("Title");
	}
	void StartGame(){
	
		//Debug.Log("recieved the signal of StartGame method at Timekeeper");
		enabled = true;
		
		audio.PlayOneShot(battleBGM);
	}

}

