using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent enemyAgent;
	public static int health = 15;
	public AudioClip hit;
	public bool hasSpawned;


	// Use this for initialization
	void Start () {
		health = 15;
		hasSpawned = false;
		enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		target = GameObject.Find ("Player").transform;
		print ("health" + health);


	}

	// Update is called once per frame
	void Update () {
		enemyAgent.destination = target.position;
		if (health <= 0) {
			Destroy (gameObject);
		}

	}


	void OnTriggerEnter(Collider coll){
		print ("coll detected");
		if (coll.gameObject.tag == "Projectile") {
			print ("Monster hit");
			health--;
			AudioSource.PlayClipAtPoint (hit, Camera.main.transform.position);

		}
	//}
	}
	public static int getHealth(){
		return health;
	}
	public static void setHealth(int amount){
		health = amount;
	}
}
