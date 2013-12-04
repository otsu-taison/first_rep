using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Scorekeeper))]

public class Referee : MonoBehaviour {
	
	int rewardPoint = 10;
	private Scorekeeper scorekeeper;
	
	void Start () {
	
		this.scorekeeper = this.gameObject.GetComponent<Scorekeeper>();
	}
	
	void Update () {}
	
	void OnDestroyGift(string giftColorName){
		
		switch(giftColorName){
		case "blue":
			scorekeeper.score += rewardPoint;
			//Debug.Log(scorekeeper.score);
			break;
		case "red":
			scorekeeper.score += rewardPoint * 2;
			//Debug.Log(scorekeeper.score);
			break;
		case "green":
			scorekeeper.score += rewardPoint * 3;
			//Debug.Log(scorekeeper.score);
			break;
		}
	}
	void StartGame(){
			//Debug.Log("recieved the signal of StartGame method at Referee");

		enabled = true;
	}
	void TimeUp(){
	
		enabled = false;
	}
}
