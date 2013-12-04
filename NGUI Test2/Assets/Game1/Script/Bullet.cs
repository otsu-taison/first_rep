using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Dragon"){
			//Debug.Log("hit dragon!");
			//Destroy(collision.gameObject, 3);
			
			collision.gameObject.SendMessage("ApplyDamage");
		}
		Destroy(gameObject, 2);
	}

	void Start () {}	
	void Update () {}
	
	void OnBecameInvisible(){
	
		Destroy(gameObject);
	}
}
