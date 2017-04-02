using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public GameObject deathExplosion;
	public static int playerHealth = 100;
	int damage = 2;
	int bossDamage = 8;
	public bool isDead = false;
	public AudioClip explosion;
	void Start(){
		
		playerHealth = 100;
	}
	void Update(){
		if (playerHealth <= 0 && isDead == false) {
			HealthText.current_health = 0;
            Instantiate(deathExplosion, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint (explosion, Camera.main.transform.position);
			Destroy(gameObject);

		}
	}

	void OnTriggerEnter(Collider _collision){
		if (_collision.gameObject.tag == "Enemy") {
			playerHealth -= damage;
			print ("oh no I've been hit!" + playerHealth);
			HealthText.current_health = playerHealth;
		} if (_collision.gameObject.tag == "Boss") {
			playerHealth -= bossDamage;
			HealthText.current_health = playerHealth;
			print ("boss hit");
		}
	}
	public static int getHealth (){
		return playerHealth;
	}
}