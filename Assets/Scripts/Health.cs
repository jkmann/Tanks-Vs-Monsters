using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int playerHealth = 100;
	int damage = 2;

	void Start(){
		print (playerHealth);
	}

	void OnCollisionEnter(Collision _collision){
		if(_collision.gameObject.tag=="Enemy"){
			playerHealth -= damage;
			print ("oh no I've been hit!" + playerHealth);
			HealthText.current_health = playerHealth;
		}
	}
}