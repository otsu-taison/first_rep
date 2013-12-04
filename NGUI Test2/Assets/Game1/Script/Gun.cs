using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject bulletPrefab;
	public float initialVelocity; 
	
	private int bullet_max;
	private int bullet_count;
	
	public AudioClip bulletSE;
	
	void Start () {
		
		bullet_max = 10;
		enabled = false;
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;			
			Vector3 screenPoint = Input.mousePosition;
			screenPoint.z = 10.0f;
			Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
			Vector3 direction = (worldPoint - transform.position).normalized;			
			bullet.rigidbody.velocity = direction * initialVelocity;
			
			audio.PlayOneShot(bulletSE);
			
			bullet_count++;
		}
	}
	void StartGame(){
			//Debug.Log("recieved the signal of StartGame method at Gun");

		enabled = true;
	}

	void TimeUp(){
	
		enabled = false;
	}
	
	void OnGUI(){
		
		
	}
}
