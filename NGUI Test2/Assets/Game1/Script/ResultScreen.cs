using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Scorekeeper))]

public class ResultScreen : MonoBehaviour {

	public GUISkin skin;
	
	private Scorekeeper scorekeeper;
	private string state;
	
	public AudioClip resultSE;
	
	public GameObject explosionPrefab;
	
	public bool fireworks_toggle;
	
	void Start () {
	
		this.scorekeeper = this.gameObject.GetComponent<Scorekeeper>();
	}
	
	void Update () {
	
		if(fireworks_toggle){
			
		float fireworks_position = Random.Range(-5.0f, 5.0f);
		
		Instantiate(explosionPrefab, new Vector3(fireworks_position, 0.0f, 10.5f), Quaternion.identity);
		}
	}
	
	void TimeUp(){
	
		state = "Time Up!!!";
		//yield return new WaitForSeconds(3.0f);
		state = "";
		//yield return new WaitForSeconds(0.5f);
		state = "Show Score";
		//int x = 10;
		
		/*
		if(Input.GetMouseButtonDown(0)){
			
			Debug.Log("mouse clicked");
			this.ShowTitleAgain();
		}
		*/
		
		 fireworks_toggle = true;
		
		audio.PlayOneShot(resultSE);
	}
	
	void OnGUI(){
		
		int sw = Screen.width;
		int sh = Screen.height;
		GUI.skin = skin;
		if(state == "Time Up"){
			
			GUI.Label(new Rect(0, 0, sw, sh), "Time Up", "message");
		}
		else if(state == "Show Score"){
			
			string scoreText = "Your score is " + scorekeeper.score.ToString();
			GUI.Label(new Rect(0, sh / 4, sw, sh / 4), scoreText, "message");
			//GUI.Label(new Rect(0, sh / 2, sw, sh / 4), "Click to Exit", "message");
			
		}
	}
	
	void ShowTitleAgain(){
	
		Application.LoadLevel("Title");
	}
	
}
