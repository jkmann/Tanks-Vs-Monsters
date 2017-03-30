using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public GameObject deathExplosion;
	public int playerHealth = 100;
	int damage = 20;

	void Start(){
		print (playerHealth);
	}
	void Update(){
		if (playerHealth <= 0) {
			playerHealth = 0;
            Instantiate(deathExplosion, transform.position, Quaternion.identity);
			Destroy(GameObject.Find("Player"));
		}
	}

	void OnCollisionEnter(Collision _collision){
		if(_collision.gameObject.tag=="Enemy"){
			playerHealth -= damage;
			print ("oh no I've been hit!" + playerHealth);
			HealthText.current_health = playerHealth;
		}
	}
}