using UnityEngine;
using System.Collections;

public class GiftGenerator : MonoBehaviour {

	public GameObject blueDragonPrefab;
	public GameObject redDragonPrefab;
	public GameObject greenDragonPrefab;
	
	public float interval;
	private float timer;
	
	private int gift_NUM = 5;
	
	void Start () {
	
		timer = 0.0f;
		this.createGift();
		//enabled = false;
	}
	
	void Update () {}
	
	void createGift(){
		for(int x = 0; x < gift_NUM; x++){
			
			//int dragon = Random.Range(0, 2);
			
			Vector3 first = new Vector3(-3.5f, 8.13f, 6.251892f);
			Vector3 second = new Vector3(3.6f, 8.13f, 6.251892f);
			Vector3 third = new Vector3(-4.1f, 4.8f, 6.251892f);
			Vector3 fourth = new Vector3(0.0f, 4.8f, 6.251892f);
			Vector3 fifth = new Vector3(4.25f, 4.8f, 6.251892f);
			
			//Random rand = new Random();			
			//var gift_position = new[] { first, second, third, fourth, fifth }; 
			
			switch(x){
			case 0:
				Instantiate(blueDragonPrefab, first, blueDragonPrefab.transform.rotation);
			break;
			case 1:
				Instantiate(redDragonPrefab, second, redDragonPrefab.transform.rotation);
			break;
			case 2:
				Instantiate(redDragonPrefab, third, redDragonPrefab.transform.rotation);
			break;
			case 3:
				Instantiate(blueDragonPrefab, fourth, blueDragonPrefab.transform.rotation);
			break;
			case 4:
				Instantiate(greenDragonPrefab, fifth, greenDragonPrefab.transform.rotation);
			break;
			}
		}
	}
	void StartGame(){
			//Debug.Log("recieved the signal of StartGame method at GiftGenerator");

		enabled = true;
	}
	void TimeUp(){
	
		enabled = false;
	}
}
