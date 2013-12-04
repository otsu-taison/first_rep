using UnityEngine;
using System.Collections;

public class Gift : MonoBehaviour {
	
	public GameObject explosion2Prefab;
	
	public AudioClip blueSE;
	public AudioClip redSE;
	public AudioClip greenSE;

	public string colorName;
	
	void Start () {}
	void Update () {}
	
	void ApplyDamage(){
	
		switch(colorName){
		case "blue":
			audio.PlayOneShot(blueSE);
			break;
		case "red":
		audio.PlayOneShot(redSE);
			break;
		case "green":
		audio.PlayOneShot(greenSE);
			break;
		}

		GameObject gameController = GameObject.FindWithTag("GameController");
		gameController.SendMessage("OnDestroyGift", colorName);
		
		Instantiate(explosion2Prefab, transform.position, Quaternion.identity);
		Destroy(gameObject, 3);
	}
}
